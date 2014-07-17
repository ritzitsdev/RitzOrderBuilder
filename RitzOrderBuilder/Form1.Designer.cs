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
      this.btnPreview = new System.Windows.Forms.Button();
      this.lblPageCount = new System.Windows.Forms.Label();
      this.lblExtraPages = new System.Windows.Forms.Label();
      this.lblOrderTotal = new System.Windows.Forms.Label();
      this.pageCount = new System.Windows.Forms.Label();
      this.extraPages = new System.Windows.Forms.Label();
      this.orderTotal = new System.Windows.Forms.Label();
      this.lblInstructions1 = new System.Windows.Forms.Label();
      this.btnUpdateForm = new System.Windows.Forms.Button();
      this.btnClearForm = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.chkPrint = new System.Windows.Forms.CheckBox();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.custPhone = new System.Windows.Forms.MaskedTextBox();
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
      this.lblDownloading.Location = new System.Drawing.Point(2, 10);
      this.lblDownloading.Name = "lblDownloading";
      this.lblDownloading.Size = new System.Drawing.Size(119, 13);
      this.lblDownloading.TabIndex = 0;
      this.lblDownloading.Text = "Updating. Please wait...";
      // 
      // selStoreNumber
      // 
      this.selStoreNumber.Enabled = false;
      this.selStoreNumber.FormattingEnabled = true;
      this.selStoreNumber.Location = new System.Drawing.Point(16, 28);
      this.selStoreNumber.Name = "selStoreNumber";
      this.selStoreNumber.Size = new System.Drawing.Size(101, 21);
      this.selStoreNumber.TabIndex = 1;
      this.selStoreNumber.Text = "Select Store";
      // 
      // lblCustInfo
      // 
      this.lblCustInfo.AutoSize = true;
      this.lblCustInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCustInfo.Location = new System.Drawing.Point(5, 58);
      this.lblCustInfo.Name = "lblCustInfo";
      this.lblCustInfo.Size = new System.Drawing.Size(126, 13);
      this.lblCustInfo.TabIndex = 2;
      this.lblCustInfo.Text = "Customer Information";
      // 
      // custFirstName
      // 
      this.custFirstName.Location = new System.Drawing.Point(17, 92);
      this.custFirstName.Name = "custFirstName";
      this.custFirstName.Size = new System.Drawing.Size(97, 20);
      this.custFirstName.TabIndex = 3;
      // 
      // lblFirstName
      // 
      this.lblFirstName.AutoSize = true;
      this.lblFirstName.Location = new System.Drawing.Point(18, 77);
      this.lblFirstName.Name = "lblFirstName";
      this.lblFirstName.Size = new System.Drawing.Size(57, 13);
      this.lblFirstName.TabIndex = 4;
      this.lblFirstName.Text = "First Name";
      // 
      // custLastName
      // 
      this.custLastName.Location = new System.Drawing.Point(127, 92);
      this.custLastName.Name = "custLastName";
      this.custLastName.Size = new System.Drawing.Size(100, 20);
      this.custLastName.TabIndex = 5;
      // 
      // lblLastName
      // 
      this.lblLastName.AutoSize = true;
      this.lblLastName.Location = new System.Drawing.Point(128, 77);
      this.lblLastName.Name = "lblLastName";
      this.lblLastName.Size = new System.Drawing.Size(58, 13);
      this.lblLastName.TabIndex = 6;
      this.lblLastName.Text = "Last Name";
      // 
      // lblPhone
      // 
      this.lblPhone.AutoSize = true;
      this.lblPhone.Location = new System.Drawing.Point(244, 77);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new System.Drawing.Size(38, 13);
      this.lblPhone.TabIndex = 8;
      this.lblPhone.Text = "Phone";
      // 
      // custEmail
      // 
      this.custEmail.Location = new System.Drawing.Point(16, 132);
      this.custEmail.Name = "custEmail";
      this.custEmail.Size = new System.Drawing.Size(210, 20);
      this.custEmail.TabIndex = 9;
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Location = new System.Drawing.Point(16, 117);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(32, 13);
      this.lblEmail.TabIndex = 10;
      this.lblEmail.Text = "Email";
      // 
      // lblSelectProduct
      // 
      this.lblSelectProduct.AutoSize = true;
      this.lblSelectProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSelectProduct.Location = new System.Drawing.Point(8, 253);
      this.lblSelectProduct.Name = "lblSelectProduct";
      this.lblSelectProduct.Size = new System.Drawing.Size(91, 13);
      this.lblSelectProduct.TabIndex = 11;
      this.lblSelectProduct.Text = "Select Product";
      // 
      // productList
      // 
      this.productList.FormattingEnabled = true;
      this.productList.Location = new System.Drawing.Point(17, 270);
      this.productList.Name = "productList";
      this.productList.Size = new System.Drawing.Size(299, 21);
      this.productList.TabIndex = 15;
      this.productList.Text = "Select Product";
      // 
      // lblSelectBookPDF
      // 
      this.lblSelectBookPDF.AutoSize = true;
      this.lblSelectBookPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSelectBookPDF.Location = new System.Drawing.Point(6, 164);
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
      this.button1.Location = new System.Drawing.Point(322, 179);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 12;
      this.button1.Text = "Browse";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // PDFLocation
      // 
      this.PDFLocation.Location = new System.Drawing.Point(17, 180);
      this.PDFLocation.Name = "PDFLocation";
      this.PDFLocation.Size = new System.Drawing.Size(299, 20);
      this.PDFLocation.TabIndex = 11;
      // 
      // lblCoverPath
      // 
      this.lblCoverPath.AutoSize = true;
      this.lblCoverPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCoverPath.Location = new System.Drawing.Point(7, 207);
      this.lblCoverPath.Name = "lblCoverPath";
      this.lblCoverPath.Size = new System.Drawing.Size(209, 13);
      this.lblCoverPath.TabIndex = 16;
      this.lblCoverPath.Text = "Location of JPG for the Book Cover";
      // 
      // jpgLocation
      // 
      this.jpgLocation.Location = new System.Drawing.Point(17, 224);
      this.jpgLocation.Name = "jpgLocation";
      this.jpgLocation.Size = new System.Drawing.Size(299, 20);
      this.jpgLocation.TabIndex = 13;
      // 
      // openFileDialog2
      // 
      this.openFileDialog2.Filter = "JPG Files (*.jpg)|*.jpg";
      this.openFileDialog2.InitialDirectory = "%USERPROFILE%\\desktop";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(322, 222);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 14;
      this.button2.Text = "Browse";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(322, 253);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 19;
      this.label1.Text = "Quantity";
      // 
      // quantity
      // 
      this.quantity.Location = new System.Drawing.Point(322, 270);
      this.quantity.Name = "quantity";
      this.quantity.Size = new System.Drawing.Size(75, 20);
      this.quantity.TabIndex = 16;
      this.quantity.Text = "1";
      // 
      // btnCreateOrder
      // 
      this.btnCreateOrder.Location = new System.Drawing.Point(324, 411);
      this.btnCreateOrder.Name = "btnCreateOrder";
      this.btnCreateOrder.Size = new System.Drawing.Size(75, 23);
      this.btnCreateOrder.TabIndex = 18;
      this.btnCreateOrder.Text = "Create Order";
      this.btnCreateOrder.UseVisualStyleBackColor = true;
      this.btnCreateOrder.Visible = false;
      this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
      // 
      // btnPreview
      // 
      this.btnPreview.Location = new System.Drawing.Point(325, 411);
      this.btnPreview.Name = "btnPreview";
      this.btnPreview.Size = new System.Drawing.Size(75, 23);
      this.btnPreview.TabIndex = 17;
      this.btnPreview.Text = "Next";
      this.btnPreview.UseVisualStyleBackColor = true;
      this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
      // 
      // lblPageCount
      // 
      this.lblPageCount.AutoSize = true;
      this.lblPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPageCount.Location = new System.Drawing.Point(37, 308);
      this.lblPageCount.Name = "lblPageCount";
      this.lblPageCount.Size = new System.Drawing.Size(77, 13);
      this.lblPageCount.TabIndex = 24;
      this.lblPageCount.Text = "Page Count:";
      // 
      // lblExtraPages
      // 
      this.lblExtraPages.AutoSize = true;
      this.lblExtraPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblExtraPages.Location = new System.Drawing.Point(8, 324);
      this.lblExtraPages.Name = "lblExtraPages";
      this.lblExtraPages.Size = new System.Drawing.Size(106, 13);
      this.lblExtraPages.TabIndex = 25;
      this.lblExtraPages.Text = "Additional Pages:";
      // 
      // lblOrderTotal
      // 
      this.lblOrderTotal.AutoSize = true;
      this.lblOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOrderTotal.Location = new System.Drawing.Point(39, 341);
      this.lblOrderTotal.Name = "lblOrderTotal";
      this.lblOrderTotal.Size = new System.Drawing.Size(75, 13);
      this.lblOrderTotal.TabIndex = 26;
      this.lblOrderTotal.Text = "Order Total:";
      // 
      // pageCount
      // 
      this.pageCount.AutoSize = true;
      this.pageCount.Location = new System.Drawing.Point(113, 308);
      this.pageCount.Name = "pageCount";
      this.pageCount.Size = new System.Drawing.Size(0, 13);
      this.pageCount.TabIndex = 28;
      // 
      // extraPages
      // 
      this.extraPages.AutoSize = true;
      this.extraPages.Location = new System.Drawing.Point(112, 324);
      this.extraPages.Name = "extraPages";
      this.extraPages.Size = new System.Drawing.Size(0, 13);
      this.extraPages.TabIndex = 29;
      // 
      // orderTotal
      // 
      this.orderTotal.AutoSize = true;
      this.orderTotal.Location = new System.Drawing.Point(114, 341);
      this.orderTotal.Name = "orderTotal";
      this.orderTotal.Size = new System.Drawing.Size(0, 13);
      this.orderTotal.TabIndex = 30;
      // 
      // lblInstructions1
      // 
      this.lblInstructions1.AutoSize = true;
      this.lblInstructions1.Location = new System.Drawing.Point(10, 363);
      this.lblInstructions1.MaximumSize = new System.Drawing.Size(400, 0);
      this.lblInstructions1.Name = "lblInstructions1";
      this.lblInstructions1.Size = new System.Drawing.Size(395, 26);
      this.lblInstructions1.TabIndex = 31;
      this.lblInstructions1.Text = "Verify Settings and click Create Order.  If you make changes click Update to save" +
    " them.  Order Total does not include taxes.";
      this.lblInstructions1.Visible = false;
      // 
      // btnUpdateForm
      // 
      this.btnUpdateForm.Location = new System.Drawing.Point(240, 411);
      this.btnUpdateForm.Name = "btnUpdateForm";
      this.btnUpdateForm.Size = new System.Drawing.Size(75, 23);
      this.btnUpdateForm.TabIndex = 32;
      this.btnUpdateForm.Text = "Update";
      this.btnUpdateForm.UseVisualStyleBackColor = true;
      this.btnUpdateForm.Visible = false;
      this.btnUpdateForm.Click += new System.EventHandler(this.btnUpdateForm_Click);
      // 
      // btnClearForm
      // 
      this.btnClearForm.Location = new System.Drawing.Point(154, 411);
      this.btnClearForm.Name = "btnClearForm";
      this.btnClearForm.Size = new System.Drawing.Size(75, 23);
      this.btnClearForm.TabIndex = 33;
      this.btnClearForm.Text = "Clear Form";
      this.btnClearForm.UseVisualStyleBackColor = true;
      this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(68, 411);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 34;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // chkPrint
      // 
      this.chkPrint.AutoSize = true;
      this.chkPrint.Checked = true;
      this.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkPrint.Location = new System.Drawing.Point(243, 391);
      this.chkPrint.Name = "chkPrint";
      this.chkPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.chkPrint.Size = new System.Drawing.Size(157, 17);
      this.chkPrint.TabIndex = 35;
      this.chkPrint.Text = "Print an invoice of this order";
      this.chkPrint.UseVisualStyleBackColor = true;
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkLabel1.Location = new System.Drawing.Point(322, 10);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(68, 13);
      this.linkLabel1.TabIndex = 36;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Order History";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // custPhone
      // 
      this.custPhone.Location = new System.Drawing.Point(243, 92);
      this.custPhone.Mask = "(999) 000-0000";
      this.custPhone.Name = "custPhone";
      this.custPhone.Size = new System.Drawing.Size(91, 20);
      this.custPhone.TabIndex = 37;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(417, 444);
      this.Controls.Add(this.custPhone);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.chkPrint);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnClearForm);
      this.Controls.Add(this.btnUpdateForm);
      this.Controls.Add(this.lblInstructions1);
      this.Controls.Add(this.orderTotal);
      this.Controls.Add(this.extraPages);
      this.Controls.Add(this.pageCount);
      this.Controls.Add(this.lblOrderTotal);
      this.Controls.Add(this.lblExtraPages);
      this.Controls.Add(this.lblPageCount);
      this.Controls.Add(this.btnPreview);
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
    public System.Windows.Forms.TextBox custEmail;
    public System.Windows.Forms.TextBox PDFLocation;
    public System.Windows.Forms.TextBox jpgLocation;
    public System.Windows.Forms.ComboBox productList;
    public System.Windows.Forms.TextBox quantity;
    public System.Windows.Forms.Label lblPageCount;
    public System.Windows.Forms.Label lblExtraPages;
    public System.Windows.Forms.Label lblOrderTotal;
    public System.Windows.Forms.Button btnPreview;
    public System.Windows.Forms.Button btnCreateOrder;
    public System.Windows.Forms.Label pageCount;
    public System.Windows.Forms.Label extraPages;
    public System.Windows.Forms.Label orderTotal;
    public System.Windows.Forms.Label lblInstructions1;
    public System.Windows.Forms.Button btnUpdateForm;
    private System.Windows.Forms.Button btnClearForm;
    private System.Windows.Forms.Button btnCancel;
    public System.Windows.Forms.CheckBox chkPrint;
    private System.Windows.Forms.LinkLabel linkLabel1;
    public System.Windows.Forms.MaskedTextBox custPhone;
  }
}

