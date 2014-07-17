using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RitzOrderBuilder
{
  public partial class OrderHistory : Form
  {
    public OrderHistory()
    {
      InitializeComponent();
    }

    private void btnViewHistory_Click(object sender, EventArgs e)
    {
      string logPath = @"C:\Program Files\ITS\OrderBuilder\OrderLog.xml";
      string orderNum = txtOrderNum.Text;

      if (!File.Exists(logPath))
      {
        MessageBox.Show("Order not found.");
      }
      else
      {
        XDocument xLogEntries = XDocument.Load(logPath);
        var qryLogEntries = from orders in xLogEntries.Descendants("order")
                            where (string)orders.Attribute("order_number").Value == orderNum
                            select orders;
        foreach (var item in qryLogEntries)
        {
          txtTimeStamp.Text = item.Attribute("timestamp").Value;
          txtProduct.Text = item.Element("product").Value;
          txtQuantity.Text = item.Element("quantity").Value;
          txtOrderTotal.Text = "$" + item.Element("order_total").Value;
          txtPDFName.Text = item.Element("pdf_name").Value;
          txtJPGName.Text = item.Element("jpg_name").Value;
          txtPageCount.Text = item.Element("page_count").Value;
          txtExtraPages.Text = item.Element("extra_pages").Value;
          txtCustName.Text = item.Element("customer_info").Element("first_name").Value;
          txtCustName.Text += " " + item.Element("customer_info").Element("last_name").Value;
          txtPhone.Text = item.Element("customer_info").Element("phone").Value;
          txtEmail.Text = item.Element("customer_info").Element("email").Value;
        }
      }
    } //end btnViewHistory_Click

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    } //end btnClose_Click
  }
}
