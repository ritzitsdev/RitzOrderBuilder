namespace RitzOrderBuilder
{
  partial class Form1
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
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.lblDownloading = new System.Windows.Forms.Label();
      this.selStoreNumber = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      // 
      // lblDownloading
      // 
      this.lblDownloading.AutoSize = true;
      this.lblDownloading.Location = new System.Drawing.Point(2, 26);
      this.lblDownloading.Name = "lblDownloading";
      this.lblDownloading.Size = new System.Drawing.Size(119, 13);
      this.lblDownloading.TabIndex = 0;
      this.lblDownloading.Text = "Updating. Please wait...";
      // 
      // selStoreNumber
      // 
      this.selStoreNumber.Enabled = false;
      this.selStoreNumber.FormattingEnabled = true;
      this.selStoreNumber.Location = new System.Drawing.Point(5, 72);
      this.selStoreNumber.Name = "selStoreNumber";
      this.selStoreNumber.Size = new System.Drawing.Size(121, 21);
      this.selStoreNumber.TabIndex = 1;
      this.selStoreNumber.Text = "Select Store";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(397, 376);
      this.Controls.Add(this.selStoreNumber);
      this.Controls.Add(this.lblDownloading);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Label lblDownloading;
    private System.Windows.Forms.ComboBox selStoreNumber;
  }
}

