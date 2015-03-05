namespace Pirate.Voting.RRV
{
  partial class Master
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabs = new System.Windows.Forms.TabControl();
      this.inputPage = new System.Windows.Forms.TabPage();
      this.electionControl = new Pirate.Voting.RRV.ElectionControl();
      this.resultPage = new System.Windows.Forms.TabPage();
      this.resultsControl = new Pirate.Voting.RRV.ResultGrid();
      this.menuStrip1.SuspendLayout();
      this.tabs.SuspendLayout();
      this.inputPage.SuspendLayout();
      this.resultPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.resultsControl)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(865, 24);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // neuToolStripMenuItem
      // 
      this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
      this.neuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.neuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
      this.neuToolStripMenuItem.Text = "&Neu";
      this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
      this.openToolStripMenuItem.Text = "Ö&ffnen";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
      this.saveToolStripMenuItem.Text = "&Speichern";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // tabs
      // 
      this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabs.Controls.Add(this.inputPage);
      this.tabs.Controls.Add(this.resultPage);
      this.tabs.Location = new System.Drawing.Point(0, 27);
      this.tabs.Name = "tabs";
      this.tabs.SelectedIndex = 0;
      this.tabs.Size = new System.Drawing.Size(865, 413);
      this.tabs.TabIndex = 3;
      this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
      // 
      // inputPage
      // 
      this.inputPage.Controls.Add(this.electionControl);
      this.inputPage.Location = new System.Drawing.Point(4, 35);
      this.inputPage.Name = "inputPage";
      this.inputPage.Padding = new System.Windows.Forms.Padding(3);
      this.inputPage.Size = new System.Drawing.Size(857, 374);
      this.inputPage.TabIndex = 0;
      this.inputPage.Text = "Eingabe";
      this.inputPage.UseVisualStyleBackColor = true;
      // 
      // electionControl
      // 
      this.electionControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.electionControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.electionControl.Location = new System.Drawing.Point(0, 0);
      this.electionControl.Margin = new System.Windows.Forms.Padding(6);
      this.electionControl.Name = "electionControl";
      this.electionControl.Size = new System.Drawing.Size(857, 374);
      this.electionControl.TabIndex = 0;
      // 
      // resultPage
      // 
      this.resultPage.Controls.Add(this.resultsControl);
      this.resultPage.Location = new System.Drawing.Point(4, 35);
      this.resultPage.Name = "resultPage";
      this.resultPage.Padding = new System.Windows.Forms.Padding(3);
      this.resultPage.Size = new System.Drawing.Size(857, 374);
      this.resultPage.TabIndex = 1;
      this.resultPage.Text = "Resultate";
      this.resultPage.UseVisualStyleBackColor = true;
      // 
      // resultsControl
      // 
      this.resultsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.resultsControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.resultsControl.Location = new System.Drawing.Point(0, 0);
      this.resultsControl.Name = "resultsControl";
      this.resultsControl.ReadOnly = true;
      this.resultsControl.Size = new System.Drawing.Size(857, 374);
      this.resultsControl.TabIndex = 0;
      this.resultsControl.Click += new System.EventHandler(this.resultsControl_Click);
      // 
      // Master
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(865, 442);
      this.Controls.Add(this.tabs);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Master";
      this.Text = "Pirate RRV";
      this.Load += new System.EventHandler(this.Master_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabs.ResumeLayout(false);
      this.inputPage.ResumeLayout(false);
      this.resultPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.resultsControl)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.TabControl tabs;
    private System.Windows.Forms.TabPage inputPage;
    private ElectionControl electionControl;
    private System.Windows.Forms.TabPage resultPage;
    private ResultGrid resultsControl;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
  }
}

