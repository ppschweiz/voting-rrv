using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Pirate.Voting.RRV
{
  public class ResultGrid : DataGridView 
  {
    private Election _election;
    private Dictionary<Candidate, int> _rows;
    private int _index;
    private int _winnerCount;

    public ResultGrid()
    {
      ReadOnly = true;
    }

    public void Prepare(Election election)
    {
      Rows.Clear();
      Columns.Clear();
      _election = election;

      Columns.Add("k", "Kandidat");
      Columns[0].Width = 200;
      Columns.Add("c", "Resultat");
      Columns[1].Width = 120;

      switch (_election.Majority)
      {
        case Majority.Absolute:
        case Majority.Twothirds:
          Columns.Add("m", "Mehrheit");
          Columns[2].Width = 120;
          Columns[2].DefaultCellStyle.Format = "0.000";
          break;
      }

      for (int i = 0; i < _election.Seats; i++)
      {
        var column = new DataGridViewTextBoxColumn();
        column.HeaderText = (i + 1).ToString() + ". WG";
        column.Name = "wg" + i;
        column.Width = 120;
        column.DefaultCellStyle.Format = "0.000";
        Columns.Add(column);
      }

      _rows = new Dictionary<Candidate, int>();

      foreach (var c in _election.Candidates)
      {
        var index = Rows.Add(c.Name);
        _rows.Add(c, index);
      }

      _index = 0;
      _winnerCount = 0;
    }

    public void Round()
    {
      if (_winnerCount >= _election.Seats ||
          _election.Candidates.Count < 1)
      {
        return;
      }

      if (_index == 0)
      {
        switch (_election.Majority)
        {
          case Majority.Absolute:
          case Majority.Twothirds:
            ApplyMajority();
            _index++;
            return;
        }
      }

      var sums = new Dictionary<Candidate, double>();

      foreach (var candidate in _election.Candidates)
      {
        var sum = _election.Ballots.Sum(b => b.Votes[candidate] * b.Weight);
        sums.Add(candidate, sum);
        this[_index + 2, _rows[candidate]].Value = sum;
      }

      var winnerValue = sums.OrderByDescending(c => c.Value).First().Value;
      var winnerCount = 0;

      foreach (var winner in sums
        .Where(c => c.Value == winnerValue)
        .Select(c => c.Key))
      {
        winnerCount++;

        foreach (var ballot in _election.Ballots)
        {
          ballot.Success += ballot.Votes[winner] * ballot.Weight;
          ballot.Weight = 1d / (1d + ballot.Success / 99d);
        }

        this[1, _rows[winner]].Value = (_winnerCount + 1).ToString() + ".";
        this[1, _rows[winner]].Style.BackColor = Color.LightGreen;

        Eliminate(winner);
      }

      _winnerCount += winnerCount;
      _index++;
    }

    private void ApplyMajority()
    {
      var total = _election.Ballots.Count;

      foreach (var candidate in _election.Candidates.ToList())
      {
        var approved = _election.Ballots.Where(b => b.Votes[candidate] > 0).Count();
        var approval = 1d / total * approved;
        this[2, _rows[candidate]].Value = (100d * approval);

        if ((_election.Majority == Majority.Absolute && approved >= total / 2 + 1) ||
            (_election.Majority == Majority.Twothirds && approved >= (total - approved) * 2))
        {
          this[2, _rows[candidate]].Style.BackColor = Color.LightGreen;
        }
        else
        {
          this[2, _rows[candidate]].Style.BackColor = Color.FromArgb(255, 150, 150);
          Eliminate(candidate);
        }
      }
    }

    private void Eliminate(Candidate candidate)
    {
      _election.Candidates.Remove(candidate);

      foreach (var ballot in _election.Ballots)
      {
        ballot.Votes.Remove(candidate);
      }
    }

    protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
    {
      Rows[e.RowIndex].Height = Font.Height + 4;
      base.OnRowsAdded(e);
    }
  }
}
