namespace Pirate.Voting.RRV
{
  partial class Results
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
      this.resultList = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.resultList)).BeginInit();
      this.SuspendLayout();
      // 
      // resultList
      // 
      this.resultList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.resultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.resultList.Location = new System.Drawing.Point(24, 23);
      this.resultList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.resultList.Name = "resultList";
      this.resultList.RowTemplate.Height = 24;
      this.resultList.Size = new System.Drawing.Size(1684, 845);
      this.resultList.TabIndex = 0;
      // 
      // Results
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1684, 891);
      this.Controls.Add(this.resultList);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "Results";
      this.Text = "Results";
      ((System.ComponentModel.ISupportInitialize)(this.resultList)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView resultList;
  }
}