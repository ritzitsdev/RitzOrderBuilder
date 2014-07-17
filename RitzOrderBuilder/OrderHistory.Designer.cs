namespace RitzOrderBuilder
{
  partial class OrderHistory
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
      this.lblEnterOrderNum = new System.Windows.Forms.Label();
      this.txtOrderNum = new System.Windows.Forms.TextBox();
      this.btnViewHistory = new System.Windows.Forms.Button();
      this.lblOrderCreated = new System.Windows.Forms.Label();
      this.lblProduct = new System.Windows.Forms.Label();
      this.lblQuantity = new System.Windows.Forms.Label();
      this.lblOrderTotal = new System.Windows.Forms.Label();
      this.lblPDFName = new System.Windows.Forms.Label();
      this.lblJPGName = new System.Windows.Forms.Label();
      this.lblPageCount = new System.Windows.Forms.Label();
      this.lblExtraPages = new System.Windows.Forms.Label();
      this.lblCustInfo = new System.Windows.Forms.Label();
      this.lblCustName = new System.Windows.Forms.Label();
      this.lblPhone = new System.Windows.Forms.Label();
      this.lblEmail = new System.Windows.Forms.Label();
      this.txtTimeStamp = new System.Windows.Forms.Label();
      this.txtProduct = new System.Windows.Forms.Label();
      this.txtQuantity = new System.Windows.Forms.Label();
      this.txtOrderTotal = new System.Windows.Forms.Label();
      this.txtPDFName = new System.Windows.Forms.Label();
      this.txtJPGName = new System.Windows.Forms.Label();
      this.txtPageCount = new System.Windows.Forms.Label();
      this.txtExtraPages = new System.Windows.Forms.Label();
      this.txtCustName = new System.Windows.Forms.Label();
      this.txtPhone = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblEnterOrderNum
      // 
      this.lblEnterOrderNum.AutoSize = true;
      this.lblEnterOrderNum.Location = new System.Drawing.Point(11, 13);
      this.lblEnterOrderNum.Name = "lblEnterOrderNum";
      this.lblEnterOrderNum.Size = new System.Drawing.Size(101, 13);
      this.lblEnterOrderNum.TabIndex = 0;
      this.lblEnterOrderNum.Text = "Enter Order Number";
      // 
      // txtOrderNum
      // 
      this.txtOrderNum.Location = new System.Drawing.Point(13, 30);
      this.txtOrderNum.Name = "txtOrderNum";
      this.txtOrderNum.Size = new System.Drawing.Size(100, 20);
      this.txtOrderNum.TabIndex = 1;
      // 
      // btnViewHistory
      // 
      this.btnViewHistory.Location = new System.Drawing.Point(120, 28);
      this.btnViewHistory.Name = "btnViewHistory";
      this.btnViewHistory.Size = new System.Drawing.Size(75, 23);
      this.btnViewHistory.TabIndex = 2;
      this.btnViewHistory.Text = "View History";
      this.btnViewHistory.UseVisualStyleBackColor = true;
      this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
      // 
      // lblOrderCreated
      // 
      this.lblOrderCreated.AutoSize = true;
      this.lblOrderCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOrderCreated.Location = new System.Drawing.Point(13, 69);
      this.lblOrderCreated.Name = "lblOrderCreated";
      this.lblOrderCreated.Size = new System.Drawing.Size(94, 13);
      this.lblOrderCreated.TabIndex = 3;
      this.lblOrderCreated.Text = "Order Created: ";
      // 
      // lblProduct
      // 
      this.lblProduct.AutoSize = true;
      this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblProduct.Location = new System.Drawing.Point(48, 86);
      this.lblProduct.Name = "lblProduct";
      this.lblProduct.Size = new System.Drawing.Size(59, 13);
      this.lblProduct.TabIndex = 4;
      this.lblProduct.Text = "Product: ";
      // 
      // lblQuantity
      // 
      this.lblQuantity.AutoSize = true;
      this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblQuantity.Location = new System.Drawing.Point(45, 103);
      this.lblQuantity.Name = "lblQuantity";
      this.lblQuantity.Size = new System.Drawing.Size(62, 13);
      this.lblQuantity.TabIndex = 5;
      this.lblQuantity.Text = "Quantity: ";
      // 
      // lblOrderTotal
      // 
      this.lblOrderTotal.AutoSize = true;
      this.lblOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOrderTotal.Location = new System.Drawing.Point(28, 121);
      this.lblOrderTotal.Name = "lblOrderTotal";
      this.lblOrderTotal.Size = new System.Drawing.Size(79, 13);
      this.lblOrderTotal.TabIndex = 6;
      this.lblOrderTotal.Text = "Order Total: ";
      // 
      // lblPDFName
      // 
      this.lblPDFName.AutoSize = true;
      this.lblPDFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPDFName.Location = new System.Drawing.Point(33, 149);
      this.lblPDFName.Name = "lblPDFName";
      this.lblPDFName.Size = new System.Drawing.Size(75, 13);
      this.lblPDFName.TabIndex = 7;
      this.lblPDFName.Text = "PDF Name: ";
      // 
      // lblJPGName
      // 
      this.lblJPGName.AutoSize = true;
      this.lblJPGName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblJPGName.Location = new System.Drawing.Point(34, 166);
      this.lblJPGName.Name = "lblJPGName";
      this.lblJPGName.Size = new System.Drawing.Size(74, 13);
      this.lblJPGName.TabIndex = 8;
      this.lblJPGName.Text = "JPG Name: ";
      // 
      // lblPageCount
      // 
      this.lblPageCount.AutoSize = true;
      this.lblPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPageCount.Location = new System.Drawing.Point(27, 182);
      this.lblPageCount.Name = "lblPageCount";
      this.lblPageCount.Size = new System.Drawing.Size(81, 13);
      this.lblPageCount.TabIndex = 9;
      this.lblPageCount.Text = "Page Count: ";
      // 
      // lblExtraPages
      // 
      this.lblExtraPages.AutoSize = true;
      this.lblExtraPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblExtraPages.Location = new System.Drawing.Point(25, 198);
      this.lblExtraPages.Name = "lblExtraPages";
      this.lblExtraPages.Size = new System.Drawing.Size(83, 13);
      this.lblExtraPages.TabIndex = 10;
      this.lblExtraPages.Text = "Extra Pages: ";
      // 
      // lblCustInfo
      // 
      this.lblCustInfo.AutoSize = true;
      this.lblCustInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCustInfo.Location = new System.Drawing.Point(13, 226);
      this.lblCustInfo.Name = "lblCustInfo";
      this.lblCustInfo.Size = new System.Drawing.Size(126, 13);
      this.lblCustInfo.TabIndex = 11;
      this.lblCustInfo.Text = "Customer Information";
      // 
      // lblCustName
      // 
      this.lblCustName.AutoSize = true;
      this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCustName.Location = new System.Drawing.Point(59, 245);
      this.lblCustName.Name = "lblCustName";
      this.lblCustName.Size = new System.Drawing.Size(47, 13);
      this.lblCustName.TabIndex = 12;
      this.lblCustName.Text = "Name: ";
      // 
      // lblPhone
      // 
      this.lblPhone.AutoSize = true;
      this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPhone.Location = new System.Drawing.Point(54, 262);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new System.Drawing.Size(51, 13);
      this.lblPhone.TabIndex = 13;
      this.lblPhone.Text = "Phone: ";
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEmail.Location = new System.Drawing.Point(60, 279);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(45, 13);
      this.lblEmail.TabIndex = 14;
      this.lblEmail.Text = "Email: ";
      // 
      // txtTimeStamp
      // 
      this.txtTimeStamp.AutoSize = true;
      this.txtTimeStamp.Location = new System.Drawing.Point(101, 69);
      this.txtTimeStamp.Name = "txtTimeStamp";
      this.txtTimeStamp.Size = new System.Drawing.Size(0, 13);
      this.txtTimeStamp.TabIndex = 15;
      // 
      // txtProduct
      // 
      this.txtProduct.AutoSize = true;
      this.txtProduct.Location = new System.Drawing.Point(101, 86);
      this.txtProduct.Name = "txtProduct";
      this.txtProduct.Size = new System.Drawing.Size(0, 13);
      this.txtProduct.TabIndex = 16;
      // 
      // txtQuantity
      // 
      this.txtQuantity.AutoSize = true;
      this.txtQuantity.Location = new System.Drawing.Point(101, 103);
      this.txtQuantity.Name = "txtQuantity";
      this.txtQuantity.Size = new System.Drawing.Size(0, 13);
      this.txtQuantity.TabIndex = 17;
      // 
      // txtOrderTotal
      // 
      this.txtOrderTotal.AutoSize = true;
      this.txtOrderTotal.Location = new System.Drawing.Point(101, 121);
      this.txtOrderTotal.Name = "txtOrderTotal";
      this.txtOrderTotal.Size = new System.Drawing.Size(0, 13);
      this.txtOrderTotal.TabIndex = 18;
      // 
      // txtPDFName
      // 
      this.txtPDFName.AutoSize = true;
      this.txtPDFName.Location = new System.Drawing.Point(101, 149);
      this.txtPDFName.Name = "txtPDFName";
      this.txtPDFName.Size = new System.Drawing.Size(0, 13);
      this.txtPDFName.TabIndex = 19;
      // 
      // txtJPGName
      // 
      this.txtJPGName.AutoSize = true;
      this.txtJPGName.Location = new System.Drawing.Point(101, 166);
      this.txtJPGName.Name = "txtJPGName";
      this.txtJPGName.Size = new System.Drawing.Size(0, 13);
      this.txtJPGName.TabIndex = 20;
      // 
      // txtPageCount
      // 
      this.txtPageCount.AutoSize = true;
      this.txtPageCount.Location = new System.Drawing.Point(101, 182);
      this.txtPageCount.Name = "txtPageCount";
      this.txtPageCount.Size = new System.Drawing.Size(0, 13);
      this.txtPageCount.TabIndex = 21;
      // 
      // txtExtraPages
      // 
      this.txtExtraPages.AutoSize = true;
      this.txtExtraPages.Location = new System.Drawing.Point(101, 198);
      this.txtExtraPages.Name = "txtExtraPages";
      this.txtExtraPages.Size = new System.Drawing.Size(0, 13);
      this.txtExtraPages.TabIndex = 22;
      // 
      // txtCustName
      // 
      this.txtCustName.AutoSize = true;
      this.txtCustName.Location = new System.Drawing.Point(100, 245);
      this.txtCustName.Name = "txtCustName";
      this.txtCustName.Size = new System.Drawing.Size(0, 13);
      this.txtCustName.TabIndex = 23;
      // 
      // txtPhone
      // 
      this.txtPhone.AutoSize = true;
      this.txtPhone.Location = new System.Drawing.Point(100, 262);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(0, 13);
      this.txtPhone.TabIndex = 24;
      // 
      // txtEmail
      // 
      this.txtEmail.AutoSize = true;
      this.txtEmail.Location = new System.Drawing.Point(100, 279);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(0, 13);
      this.txtEmail.TabIndex = 25;
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(393, 289);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 26;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // OrderHistory
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 323);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.txtCustName);
      this.Controls.Add(this.txtExtraPages);
      this.Controls.Add(this.txtPageCount);
      this.Controls.Add(this.txtJPGName);
      this.Controls.Add(this.txtPDFName);
      this.Controls.Add(this.txtOrderTotal);
      this.Controls.Add(this.txtQuantity);
      this.Controls.Add(this.txtProduct);
      this.Controls.Add(this.txtTimeStamp);
      this.Controls.Add(this.lblEmail);
      this.Controls.Add(this.lblPhone);
      this.Controls.Add(this.lblCustName);
      this.Controls.Add(this.lblCustInfo);
      this.Controls.Add(this.lblExtraPages);
      this.Controls.Add(this.lblPageCount);
      this.Controls.Add(this.lblJPGName);
      this.Controls.Add(this.lblPDFName);
      this.Controls.Add(this.lblOrderTotal);
      this.Controls.Add(this.lblQuantity);
      this.Controls.Add(this.lblProduct);
      this.Controls.Add(this.lblOrderCreated);
      this.Controls.Add(this.btnViewHistory);
      this.Controls.Add(this.txtOrderNum);
      this.Controls.Add(this.lblEnterOrderNum);
      this.Name = "OrderHistory";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "OrderHistory";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblEnterOrderNum;
    private System.Windows.Forms.TextBox txtOrderNum;
    private System.Windows.Forms.Button btnViewHistory;
    private System.Windows.Forms.Label lblOrderCreated;
    private System.Windows.Forms.Label lblProduct;
    private System.Windows.Forms.Label lblQuantity;
    private System.Windows.Forms.Label lblOrderTotal;
    private System.Windows.Forms.Label lblPDFName;
    private System.Windows.Forms.Label lblJPGName;
    private System.Windows.Forms.Label lblPageCount;
    private System.Windows.Forms.Label lblExtraPages;
    private System.Windows.Forms.Label lblCustInfo;
    private System.Windows.Forms.Label lblCustName;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label txtTimeStamp;
    private System.Windows.Forms.Label txtProduct;
    private System.Windows.Forms.Label txtQuantity;
    private System.Windows.Forms.Label txtOrderTotal;
    private System.Windows.Forms.Label txtPDFName;
    private System.Windows.Forms.Label txtJPGName;
    private System.Windows.Forms.Label txtPageCount;
    private System.Windows.Forms.Label txtExtraPages;
    private System.Windows.Forms.Label txtCustName;
    private System.Windows.Forms.Label txtPhone;
    private System.Windows.Forms.Label txtEmail;
    private System.Windows.Forms.Button btnClose;
  }
}