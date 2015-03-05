namespace Pirate.Voting.RRV
{
  partial class ElectionControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.titleBox = new System.Windows.Forms.TextBox();
      this.seatNumber = new System.Windows.Forms.NumericUpDown();
      this.votingList = new Pirate.Voting.RRV.InputGrid();
      this.majorityList = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.seatNumber)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.votingList)).BeginInit();
      this.SuspendLayout();
      // 
      // titleBox
      // 
      this.titleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.titleBox.Location = new System.Drawing.Point(0, 0);
      this.titleBox.Margin = new System.Windows.Forms.Padding(12);
      this.titleBox.Name = "titleBox";
      this.titleBox.Size = new System.Drawing.Size(803, 31);
      this.titleBox.TabIndex = 0;
      this.titleBox.Text = "New election";
      // 
      // seatNumber
      // 
      this.seatNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.seatNumber.Location = new System.Drawing.Point(990, 0);
      this.seatNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.seatNumber.Name = "seatNumber";
      this.seatNumber.Size = new System.Drawing.Size(120, 31);
      this.seatNumber.TabIndex = 4;
      this.seatNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // votingList
      // 
      this.votingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.votingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.votingList.Location = new System.Drawing.Point(0, 38);
      this.votingList.Margin = new System.Windows.Forms.Padding(6);
      this.votingList.Name = "votingList";
      this.votingList.RowTemplate.Height = 24;
      this.votingList.Size = new System.Drawing.Size(1110, 344);
      this.votingList.TabIndex = 3;
      // 
      // majorityList
      // 
      this.majorityList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.majorityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.majorityList.FormattingEnabled = true;
      this.majorityList.Items.AddRange(new object[] {
            "Keine",
            "Absolute",
            "Zweidrittel"});
      this.majorityList.Location = new System.Drawing.Point(808, 0);
      this.majorityList.Name = "majorityList";
      this.majorityList.Size = new System.Drawing.Size(176, 33);
      this.majorityList.TabIndex = 1;
      // 
      // ElectionControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.majorityList);
      this.Controls.Add(this.votingList);
      this.Controls.Add(this.seatNumber);
      this.Controls.Add(this.titleBox);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "ElectionControl";
      this.Size = new System.Drawing.Size(1110, 382);
      ((System.ComponentModel.ISupportInitialize)(this.seatNumber)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.votingList)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox titleBox;
    private System.Windows.Forms.NumericUpDown seatNumber;
    private InputGrid votingList;
    private System.Windows.Forms.ComboBox majorityList;
  }
}
