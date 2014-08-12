using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;

namespace RitzOrderBuilder
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      backgroundWorker1.RunWorkerAsync();
      showStoreInfo();
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      //Get the latest version of builderSettings.xml
      string remoteBuilderSettings = "http://ritzpix.com/media/files/OrderBuilder/builderSettings.xml";
      string localBuilderSettings = @"C:\Program Files\ITS\OrderBuilder\builderSettings.xml";

      WebClient client = new WebClient();
      client.DownloadFile(remoteBuilderSettings, localBuilderSettings);
    } //end backgroundWorker1_DoWork

    private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (!(e.Error == null))
      {
        //this.lblDownloading.Text = "Could not download updates. " + e.Error.Message;
        if(!File.Exists(@"C:\Program Files\ITS\OrderBuilder\builderSettings.xml")){
          MessageBox.Show("Unable to download lastest product list.\nPlease check you Internet connection and relaunch the application.");
        }
      }
        populateProductList();
    } //end backgroundWorker1_RunWorkerCompleted

    public void showStoreInfo()
    {
      string xmlStoreInfo = @"C:\Program Files\ITS\OrderBuilder\BuilderStoreInfo.xml";
      if (!File.Exists(xmlStoreInfo))
      {
        return;
      }
      else
      {
        lklblConfStore.Visible = false;
        lnklblChangeStore.Visible = true;
        XDocument xDocStoreInfo = XDocument.Load(xmlStoreInfo);
        var qryStoreInfo = from els in xDocStoreInfo.Descendants("store_info")
                           select els;
        foreach (var el in qryStoreInfo)
        {
          lblStoreName.Text = el.Element("store_name").Value.Replace("&", "&&");
          lblStoreNum.Text = el.Element("store_number").Value;
          lblStoreAddress.Text = el.Element("store_address").Value;
          lblStoreCityStateZip.Text = el.Element("store_city").Value + ", ";
          lblStoreCityStateZip.Text += el.Element("store_state").Value + ", ";
          lblStoreCityStateZip.Text += el.Element("store_zip").Value;
          lblStorePhone.Text = el.Element("store_phone").Value;
          lblStoreContactEmail.Text = el.Element("contact_email").Value;
          lblStoreContact.Text = el.Element("contact_name").Value;
        }
        pnlStoreInfo.Visible = true;
      }
    }

    private void populateProductList()
    {
      //populate Product List combobox
      string pathProducts = @"C:\Program Files\ITS\OrderBuilder\builderSettings.xml";
      if (File.Exists(pathProducts))
      {
        XDocument xDocProducts = XDocument.Load(pathProducts);
        var qryProducts = from products in xDocProducts.Descendants("product")
                          select new { ProductID = products.Attribute("id").Value, productName = products.Attribute("name").Value };

        productList.ValueMember = "ProductID";
        productList.DisplayMember = "productName";
        productList.DataSource = qryProducts.ToList();
        productList.BindingContext = new BindingContext();
      }
    } //end populateProductList

    private void button1_Click(object sender, EventArgs e)
    {
      DialogResult result = openFileDialog1.ShowDialog();
      string file = openFileDialog1.FileName;
      PDFLocation.Text = file;
    } //end button1_click (pdf browse button)

    private void button2_Click(object sender, EventArgs e)
    {
      DialogResult result = openFileDialog2.ShowDialog();
      string file = openFileDialog2.FileName;
      jpgLocation.Text = file;
    } //end button2_click (jpg browse button)
    
    private void btnCreateOrder_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      try
      {
        buildit build = new buildit();
        build.builder(this);
        formReset();
      }
      catch(Exception ex) {
        MessageBox.Show("There was an error building the order.\nPlease check all fields and try again.\n" + ex);
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }      
    } //end btnCreateOrder_Click
    
    private void btnPreview_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      try
      {
        Preview preview = new Preview();
        preview.buildPreview(this);
      }
      catch (Exception ex)
      {
        MessageBox.Show("There was an error building the order.\nPlease check all fields and try again.");
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    } //end btnPreview_Click 

    private void formReset()
    {
      custFirstName.Text = string.Empty;
      custLastName.Text = string.Empty;
      custPhone.Text = string.Empty;
      custEmail.Text = string.Empty;
      PDFLocation.Text = string.Empty;
      jpgLocation.Text = string.Empty;
      quantity.Text = "1";
      //orderNumber.Text = string.Empty;
      pageCount.Text = string.Empty;
      extraPages.Text = string.Empty;
      orderTotal.Text = string.Empty;
      lblInstructions1.Visible = false;
      btnCreateOrder.Visible = false;
      btnPreview.Visible = true;
      btnUpdateForm.Visible = false;
    } //end formReset

    private void btnClearForm_Click(object sender, EventArgs e)
    {
      formReset();
    } //end btnClearForm_Click

    private void btnCancel_Click(object sender, EventArgs e)
    {
      formReset();
      Application.Exit();
    } //end btnCancel_Click

    private void btnUpdateForm_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      try
      {
        Preview preview = new Preview();
        preview.buildPreview(this);
      }
      catch (Exception ex)
      {
        MessageBox.Show("There was an error building the order.\nPlease check all fields and try again.");
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    } //end btnUpdateForm_Click

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      OrderHistory form = new OrderHistory();
      form.Show();
    }

    private void lklblConfStore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      storeInfoSettings storeInfo = new storeInfoSettings();
      storeInfo.Show();
    }

    private void lnklblChangeStore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      storeInfoSettings storeInfo = new storeInfoSettings();
      storeInfo.Show();
    }
  }
}