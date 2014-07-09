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
      this.lblCustInfo = new System.Windows.Forms.Label();
      this.custFirstName = new System.Windows.Forms.TextBox();
      this.lblFirstName = new System.Windows.Forms.Label();
      this.custLastName = new System.Windows.Forms.TextBox();
      this.lblLastName = new System.Windows.Forms.Label();
      this.custPhone = new System.Windows.Forms.TextBox();
      this.lblPhone = new System.Windows.Forms.Label();
      this.custEmail = new System.Windows.Forms.TextBox();
      this.lblEmail = new System.Windows.Forms.Label();
      this.lblSelectProduct = new System.Windows.Forms.Label();
      this.productList = new System.Windows.Forms.ComboBox();
      this.lblSelectBookPDF = new System.Windows.Forms.Label();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.button1 = new System.Windows.Forms.Button();
      this.PDFLocation = new System.Windows.Forms.TextBox();
      this.lblCoverPath = new System.Windows.Forms.Label();
      this.jpgLocation = new System.Windows.Forms.TextBox();
      this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.quantity = new System.Windows.Forms.TextBox();
      this.btnCreateOrder = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
      // 
      // lblDownloading
      // 
      this.lblDownloading.AutoSize = true;
      this.lblDownloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
      this.selStoreNumber.Location = new System.Drawing.Point(16, 46);
      this.selStoreNumber.Name = "selStoreNumber";
      this.selStoreNumber.Size = new System.Drawing.Size(101, 21);
      this.selStoreNumber.TabIndex = 1;
      this.selStoreNumber.Text = "Select Store";
      // 
      // lblCustInfo
      // 
      this.lblCustInfo.AutoSize = true;
      this.lblCustInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCustInfo.Location = new System.Drawing.Point(5, 83);
      this.lblCustInfo.Name = "lblCustInfo";
      this.lblCustInfo.Size = new System.Drawing.Size(126, 13);
      this.lblCustInfo.TabIndex = 2;
      this.lblCustInfo.Text = "Customer Information";
      // 
      // custFirstName
      // 
      this.custFirstName.Location = new System.Drawing.Point(17, 119);
      this.custFirstName.Name = "custFirstName";
      this.custFirstName.Size = new System.Drawing.Size(97, 20);
      this.custFirstName.TabIndex = 3;
      // 
      // lblFirstName
      // 
      this.lblFirstName.AutoSize = true;
      this.lblFirstName.Location = new System.Drawing.Point(18, 104);
      this.lblFirstName.Name = "lblFirstName";
      this.lblFirstName.Size = new System.Drawing.Size(57, 13);
      this.lblFirstName.TabIndex = 4;
      this.lblFirstName.Text = "First Name";
      // 
      // custLastName
      // 
      this.custLastName.Location = new System.Drawing.Point(127, 119);
      this.custLastName.Name = "custLastName";
      this.custLastName.Size = new System.Drawing.Size(100, 20);
      this.custLastName.TabIndex = 5;
      // 
      // lblLastName
      // 
      this.lblLastName.AutoSize = true;
      this.lblLastName.Location = new System.Drawing.Point(128, 104);
      this.lblLastName.Name = "lblLastName";
      this.lblLastName.Size = new System.Drawing.Size(58, 13);
      this.lblLastName.TabIndex = 6;
      this.lblLastName.Text = "Last Name";
      // 
      // custPhone
      // 
      this.custPhone.Location = new System.Drawing.Point(243, 119);
      this.custPhone.Name = "custPhone";
      this.custPhone.Size = new System.Drawing.Size(91, 20);
      this.custPhone.TabIndex = 7;
      // 
      // lblPhone
      // 
      this.lblPhone.AutoSize = true;
      this.lblPhone.Location = new System.Drawing.Point(244, 104);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new System.Drawing.Size(38, 13);
      this.lblPhone.TabIndex = 8;
      this.lblPhone.Text = "Phone";
      // 
      // custEmail
      // 
      this.custEmail.Location = new System.Drawing.Point(16, 160);
      this.custEmail.Name = "custEmail";
      this.custEmail.Size = new System.Drawing.Size(210, 20);
      this.custEmail.TabIndex = 9;
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Location = new System.Drawing.Point(16, 145);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(32, 13);
      this.lblEmail.TabIndex = 10;
      this.lblEmail.Text = "Email";
      // 
      // lblSelectProduct
      // 
      this.lblSelectProduct.AutoSize = true;
      this.lblSelectProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSelectProduct.Location = new System.Drawing.Point(8, 302);
      this.lblSelectProduct.Name = "lblSelectProduct";
      this.lblSelectProduct.Size = new System.Drawing.Size(91, 13);
      this.lblSelectProduct.TabIndex = 11;
      this.lblSelectProduct.Text = "Select Product";
      // 
      // productList
      // 
      this.productList.FormattingEnabled = true;
      this.productList.Location = new System.Drawing.Point(17, 319);
      this.productList.Name = "productList";
      this.productList.Size = new System.Drawing.Size(299, 21);
      this.productList.TabIndex = 12;
      this.productList.Text = "Select Product";
      // 
      // lblSelectBookPDF
      // 
      this.lblSelectBookPDF.AutoSize = true;
      this.lblSelectBookPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSelectBookPDF.Location = new System.Drawing.Point(10, 197);
      this.lblSelectBookPDF.Name = "lblSelectBookPDF";
      this.lblSelectBookPDF.Size = new System.Drawing.Size(173, 13);
      this.lblSelectBookPDF.TabIndex = 13;
      this.lblSelectBookPDF.Text = "Location of PDF for the Book";
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";
      this.openFileDialog1.InitialDirectory = "%SytemDrive%\\%USERPROFILE%\\desktop";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(322, 212);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 14;
      this.button1.Text = "Browse";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // PDFLocation
      // 
      this.PDFLocation.Location = new System.Drawing.Point(17, 213);
      this.PDFLocation.Name = "PDFLocation";
      this.PDFLocation.Size = new System.Drawing.Size(299, 20);
      this.PDFLocation.TabIndex = 15;
      // 
      // lblCoverPath
      // 
      this.lblCoverPath.AutoSize = true;
      this.lblCoverPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCoverPath.Location = new System.Drawing.Point(11, 249);
      this.lblCoverPath.Name = "lblCoverPath";
      this.lblCoverPath.Size = new System.Drawing.Size(209, 13);
      this.lblCoverPath.TabIndex = 16;
      this.lblCoverPath.Text = "Location of JPG for the Book Cover";
      // 
      // jpgLocation
      // 
      this.jpgLocation.Location = new System.Drawing.Point(17, 266);
      this.jpgLocation.Name = "jpgLocation";
      this.jpgLocation.Size = new System.Drawing.Size(299, 20);
      this.jpgLocation.TabIndex = 17;
      // 
      // openFileDialog2
      // 
      this.openFileDialog2.Filter = "JPG Files (*.jpg)|*.jpg";
      this.openFileDialog2.InitialDirectory = "%USERPROFILE%\\desktop";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(322, 264);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 18;
      this.button2.Text = "Browse";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(322, 302);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 19;
      this.label1.Text = "Quantity";
      // 
      // quantity
      // 
      this.quantity.Location = new System.Drawing.Point(322, 319);
      this.quantity.Name = "quantity";
      this.quantity.Size = new System.Drawing.Size(75, 20);
      this.quantity.TabIndex = 20;
      this.quantity.Text = "1";
      // 
      // btnCreateOrder
      // 
      this.btnCreateOrder.Location = new System.Drawing.Point(321, 395);
      this.btnCreateOrder.Name = "btnCreateOrder";
      this.btnCreateOrder.Size = new System.Drawing.Size(75, 23);
      this.btnCreateOrder.TabIndex = 21;
      this.btnCreateOrder.Text = "Create Order";
      this.btnCreateOrder.UseVisualStyleBackColor = true;
      this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(417, 444);
      this.Controls.Add(this.btnCreateOrder);
      this.Controls.Add(this.quantity);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.jpgLocation);
      this.Controls.Add(this.lblCoverPath);
      this.Controls.Add(this.PDFLocation);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.lblSelectBookPDF);
      this.Controls.Add(this.productList);
      this.Controls.Add(this.lblSelectProduct);
      this.Controls.Add(this.lblEmail);
      this.Controls.Add(this.custEmail);
      this.Controls.Add(this.lblPhone);
      this.Controls.Add(this.custPhone);
      this.Controls.Add(this.lblLastName);
      this.Controls.Add(this.custLastName);
      this.Controls.Add(this.lblFirstName);
      this.Controls.Add(this.custFirstName);
      this.Controls.Add(this.lblCustInfo);
      this.Controls.Add(this.selStoreNumber);
      this.Controls.Add(this.lblDownloading);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ritz Order Builder";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Label lblDownloading;
    private System.Windows.Forms.Label lblCustInfo;
    private System.Windows.Forms.Label lblFirstName;
    private System.Windows.Forms.Label lblLastName;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblSelectProduct;
    private System.Windows.Forms.Label lblSelectBookPDF;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label lblCoverPath;
    private System.Windows.Forms.OpenFileDialog openFileDialog2;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.ComboBox selStoreNumber;
    public System.Windows.Forms.TextBox custFirstName;
    public System.Windows.Forms.TextBox custLastName;
    public System.Windows.Forms.TextBox custPhone;
    public System.Windows.Forms.TextBox custEmail;
    public System.Windows.Forms.TextBox PDFLocation;
    public System.Windows.Forms.TextBox jpgLocation;
    public System.Windows.Forms.ComboBox productList;
    public System.Windows.Forms.TextBox quantity;
    private System.Windows.Forms.Button btnCreateOrder;
  }
}

