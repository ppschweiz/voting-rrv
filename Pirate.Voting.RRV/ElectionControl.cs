using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pirate.Voting.RRV
{
  public partial class ElectionControl : UserControl
  {
    public ElectionControl()
    {
      InitializeComponent();
    }

    public void New()
    {
      this.titleBox.Text = "Neue Abstimmung";
      this.seatNumber.Value = 3;
      this.majorityList.SelectedIndex = (int)Majority.None;
      this.votingList.New();
    }

    public void Open(Election election)
    {
      this.titleBox.Text = election.Title;
      this.seatNumber.Value = election.Seats;
      this.majorityList.SelectedIndex = (int)election.Majority;
      this.votingList.Load(election);
    }

    public Election Get()
    {
      var election = new Election(this.titleBox.Text);
      election.Seats = (int)this.seatNumber.Value;
      election.Majority = (Majority)this.majorityList.SelectedIndex;
      this.votingList.AddCandidates(election);
      return election;
    }
  }
}
