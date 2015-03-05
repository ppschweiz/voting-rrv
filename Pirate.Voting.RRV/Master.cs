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
      this.electionControl.New();
    }

    private void tabs_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.tabs.SelectedIndex == 1)
      {
        this.resultsControl.Prepare(this.electionControl.Get());
      }
    }

    private void resultsControl_Click(object sender, EventArgs e)
    {
      this.resultsControl.Round();
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (var dialog = new SaveFileDialog())
      {
        dialog.Title = "Speichern";
        dialog.Filter = "*.rrv|*.rrv";
        dialog.CheckPathExists = true;
        
        if (dialog.ShowDialog() == DialogResult.OK)
        {
          this.electionControl.Get().Save(dialog.FileName);
        }
      }
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (var dialog = new OpenFileDialog())
      {
        dialog.Title = "Öffnen";
        dialog.Filter = "*.rrv|*.rrv";
        dialog.CheckFileExists = true;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
          var election = Election.Load(dialog.FileName);
          this.electionControl.Open(election);
        }
      }
    }

    private void neuToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.tabs.SelectedIndex = 0;
      this.electionControl.New();
    }
  }
}
