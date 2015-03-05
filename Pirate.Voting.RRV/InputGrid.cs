using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Pirate.Voting.RRV
{
  public class InputGrid : DataGridView
  {
    public void Load(Election election)
    {
      Rows.Clear();
      Columns.Clear();

      AllowUserToAddRows = true;

      Columns.Add("k", "Kandidat");
      Columns[0].Width = 200;

      foreach (var ballot in election.Ballots)
      {
        AddVote();
      }

      AddVote();

      var candidates = new Dictionary<Candidate, int>();

      foreach (var candidate in election.Candidates)
      {
        candidates.Add(candidate, Rows.Add(candidate.Name));
      }

      var index = 1;

      foreach (var ballot in election.Ballots)
      {
        foreach (var vote in ballot.Votes)
        {
          this[index, candidates[vote.Key]].Value = vote.Value.ToString();
          OnCellEndEdit(new DataGridViewCellEventArgs(index, candidates[vote.Key]));
        }

        index++;
      }
    }

    public void New()
    {
      Rows.Clear();
      Columns.Clear();

      AllowUserToAddRows = true;

      Columns.Add("k", "Kandidat");
      Columns[0].Width = 200;
      AddVote();
    }

    private void AddVote()
    {
      var column = new DataGridViewColumn();
      column.CellTemplate = Columns[0].CellTemplate;
      column.Name = "V" + Columns.Count;
      column.HeaderText = "#" + Columns.Count;
      column.Width = 70;
      Columns.Add(column);
    }

    public void AddCandidates(Election election)
    {
      var candidates = new Dictionary<int, Candidate>();

      foreach (DataGridViewRow row in Rows)
      {
        string name = row.Cells[0].Value as string;

        if (!string.IsNullOrEmpty(name))
        {
          var candidate = new Candidate(row.Index, name);
          candidates.Add(row.Index, candidate);
          election.Candidates.Add(candidate);
        }
      }

      foreach (DataGridViewColumn column in Columns)
      {
        if (column.Index != 0)
        {
          var ballot = new Ballot();
          var valid = false;

          for (int rowIndex = 0; rowIndex < Rows.Count; rowIndex++)
          {
            var cell = this[column.Index, rowIndex];
            var value = cell.Value as string;

            if (candidates.ContainsKey(rowIndex))
            {
              var candidate = candidates[rowIndex];

              int number = 0;

              if (int.TryParse(value, out number))
              {
                ballot.Votes.Add(candidate, number);
                valid = true;
              }
              else if (string.IsNullOrEmpty(value) || value == "-")
              {
                ballot.Votes.Add(candidate, 0);
              }
            }
          }

          if (valid)
          {
            election.Ballots.Add(ballot);
          }
        }
      }
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
      base.OnKeyDown(e);

      switch (e.KeyCode)
      {
        case Keys.Delete:
          foreach (DataGridViewCell cell in SelectedCells)
          {
            cell.Value = string.Empty;
            OnCellEndEdit(new DataGridViewCellEventArgs(cell.ColumnIndex, cell.RowIndex));
          }
          break;
      }
    }

    protected override void OnCellEndEdit(DataGridViewCellEventArgs e)
    {
      var cell = this[e.ColumnIndex, e.RowIndex];
      var value = cell.Value as string;

      if (e.ColumnIndex == 0)
      {
        if (!string.IsNullOrEmpty(value))
        {
          cell.Style.BackColor = Color.LightGreen;
        }
        else
        {
          cell.Style.BackColor = Color.FromArgb(255, 150, 150);
        }
      }
      else
      {
        int number = 0;

        if (int.TryParse(value, out number) && number >= 0 && number <= 99)
        {
          cell.Style.BackColor = Color.LightGreen;

          if (e.ColumnIndex + 1 == Columns.Count)
          {
            AddVote();
          }
        }
        else if (string.IsNullOrEmpty(value))
        {
          cell.Style.BackColor = Color.White;
        }
        else
        {
          cell.Style.BackColor = Color.FromArgb(255, 150, 150);

          if (e.ColumnIndex + 1 == Columns.Count)
          {
            AddVote();
          }
        }
      }

      base.OnCellEndEdit(e);
    }
  }
}
