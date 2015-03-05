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
  public partial class Results : Form
  {
    public Results()
    {
      InitializeComponent();
    }

    public void Show(Election election)
    {
      this.resultList.RowsAdded += new DataGridViewRowsAddedEventHandler(resultList_RowsAdded);

      this.resultList.Columns.Add("k", "Kandidat");
      this.resultList.Columns[0].Width = 200;
      this.resultList.Columns.Add("c", "Rang");
      this.resultList.Columns[1].Width = 150;

      for (int i = 0; i < election.Seats; i++)
      {
        var column = new DataGridViewTextBoxColumn();
        column.HeaderText = (i + 1).ToString() + ". WG";
        column.Name = "wg" + i;
        column.Width = 120;
        column.DefaultCellStyle.Format = "0.000";
        this.resultList.Columns.Add(column);
      }

      var rows = new Dictionary<Candidate, int>();

      foreach (var c in election.Candidates)
      {
        var index = this.resultList.Rows.Add(c.Name);
        rows.Add(c, index);
      }

      for (int i = 0; i < election.Seats && election.Candidates.Count > 0; i++)
      {
        var sums = new Dictionary<Candidate, double>();

        foreach (var candidate in election.Candidates)
        {
          var sum = election.Ballots.Sum(b => b.Votes[candidate] * b.Weight);
          sums.Add(candidate, sum);
          this.resultList[i + 2, rows[candidate]].Value = sum;
        }

        var winner = sums.OrderByDescending(c => c.Value).First().Key;

        foreach (var ballot in election.Ballots)
        {
          ballot.Success += ballot.Votes[winner] * ballot.Weight;
          ballot.Weight = 1d / (1d + ballot.Success / 99d);
        }

        this.resultList[1, rows[winner]].Value = (i + 1).ToString() + ".";

        election.Candidates.Remove(winner);

        foreach (var ballot in election.Ballots)
        {
          ballot.Votes.Remove(winner);
        }
      }
    }

    private void resultList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      this.resultList.Rows[e.RowIndex].Height = 36;
    }
  }
}
