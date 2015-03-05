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
      this.votingList = new System.Windows.Forms.DataGridView();
      this.titleBox = new System.Windows.Forms.TextBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.seatNumber = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.votingList)).BeginInit();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.seatNumber)).BeginInit();
      this.SuspendLayout();
      // 
      // votingList
      // 
      this.votingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.votingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.votingList.Location = new System.Drawing.Point(15, 90);
      this.votingList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.votingList.Name = "votingList";
      this.votingList.RowTemplate.Height = 24;
      this.votingList.Size = new System.Drawing.Size(1654, 903);
      this.votingList.TabIndex = 0;
      // 
      // titleBox
      // 
      this.titleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.titleBox.Location = new System.Drawing.Point(15, 40);
      this.titleBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.titleBox.Name = "titleBox";
      this.titleBox.Size = new System.Drawing.Size(1523, 38);
      this.titleBox.TabIndex = 1;
      this.titleBox.Text = "New election";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1684, 26);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // calculateToolStripMenuItem
      // 
      this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
      this.calculateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.calculateToolStripMenuItem.Text = "&Calculate";
      this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
      // 
      // seatNumber
      // 
      this.seatNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.seatNumber.Location = new System.Drawing.Point(1547, 40);
      this.seatNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.seatNumber.Name = "seatNumber";
      this.seatNumber.Size = new System.Drawing.Size(120, 38);
      this.seatNumber.TabIndex = 3;
      this.seatNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // Master
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1684, 1008);
      this.Controls.Add(this.seatNumber);
      this.Controls.Add(this.titleBox);
      this.Controls.Add(this.votingList);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "Master";
      this.Text = "Pirate RRV";
      this.Load += new System.EventHandler(this.Master_Load);
      ((System.ComponentModel.ISupportInitialize)(this.votingList)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.seatNumber)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView votingList;
    private System.Windows.Forms.TextBox titleBox;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
    private System.Windows.Forms.NumericUpDown seatNumber;
  }
}

