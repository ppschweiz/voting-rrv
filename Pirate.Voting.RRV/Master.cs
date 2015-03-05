using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pirate.Voting.RRV
{
  public partial class Master : Form
  {
    public Master()
    {
      InitializeComponent();
    }

    private void Master_Load(object sender, EventArgs e)
    {
      this.votingList.CellEndEdit += new DataGridViewCellEventHandler(votingList_CellEndEdit);
      this.votingList.AllowUserToAddRows = true;
      this.votingList.RowsAdded += new DataGridViewRowsAddedEventHandler(votingList_RowsAdded);

      this.votingList.Columns.Add("o", "Option");
      this.votingList.Columns[0].Width = 200;

      for (int i = 0; i < 12; i++)
      {
        var column = new DataGridViewColumn();
        column.CellTemplate = this.votingList.Columns[0].CellTemplate;
        column.Name = "V" + i;
        column.HeaderText = "#" + i;
        column.Width = 70;
        this.votingList.Columns.Add(column);
      }
    }

    private void votingList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      this.votingList.Rows[e.RowIndex].Height = 36;
    }

    private Election Get()
    {
      var election = new Election(this.titleBox.Text);
      election.Seats = (int)this.seatNumber.Value;

      var candidates = new Dictionary<int, Candidate>();

      foreach (DataGridViewRow row in this.votingList.Rows)
      {
        string name = row.Cells[0].Value as string;

        if (!string.IsNullOrEmpty(name))
        {
          var candidate = new Candidate(name);
          candidates.Add(row.Index, candidate);
          election.Candidates.Add(candidate);
        }
      }

      foreach (DataGridViewColumn column in this.votingList.Columns)
      {
        if (column.Index != 0)
        {
          var ballot = new Ballot();
          var valid = false;

          for (int rowIndex = 0; rowIndex < this.votingList.Rows.Count; rowIndex++)
          {
            var cell = this.votingList[column.Index, rowIndex];
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

      return election;
    }

    private void votingList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      var cell = this.votingList[e.ColumnIndex, e.RowIndex];
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

        if (int.TryParse(value, out number))
        {
          cell.Style.BackColor = Color.LightGreen;
        }
        else if (string.IsNullOrEmpty(value) || value == "-")
        {
          cell.Style.BackColor = Color.LightGray;
        }
        else
        {
          cell.Style.BackColor = Color.FromArgb(255, 150, 150);
        }
      }
    }

    private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var results = new Results();
      results.Show();
      results.Show(Get());
    }
  }
}
