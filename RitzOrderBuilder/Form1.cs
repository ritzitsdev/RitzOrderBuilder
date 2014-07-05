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
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      //Get the latest version of ritzsetup.xml (for store locations) and builderSettings.xml
      string remoteStoreInfoXml = "http://ritzpix.com/media/files/ritzsetup.xml";
      string localStoreInfoXml = @"C:\Program Files\ITS\OrderBuilder\ritzsetup.xml";
      string remoteBuilderSettings = "http://ritzpix.com/media/files/builderSettings.xml";
      string localBuilderSettings = @"C:\Program Files\ITS\OrderBuilder\builderSettings.xml";

      WebClient client = new WebClient();
      client.DownloadFile(remoteStoreInfoXml, localStoreInfoXml);
      client.DownloadFile(remoteBuilderSettings, localBuilderSettings);
    } //end backgroundWorker1_DoWork

    private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (!(e.Error == null))
      {
        this.lblDownloading.Text = "Could not download updates. " + e.Error.Message;
      }
      else
      {
        lblDownloading.Text = "Select Store";
        lblDownloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        selStoreNumber.Enabled = true;
      }
        populateStoreList();
        populateProductList();
    } //end backgroundWorker1_RunWorkerCompleted

    private void populateStoreList()
    {
      //populate store number combobox
      string pathLocations = @"C:\Program Files\ITS\OrderBuilder\ritzsetup.xml";
      if (File.Exists(pathLocations))
      {
        XDocument xDocLocations = XDocument.Load(pathLocations);
        var qryLocations = from locations in xDocLocations.Descendants("location")
                           select new { Store = locations.Attribute("store_number").Value };

        selStoreNumber.ValueMember = "Store";
        selStoreNumber.DisplayMember = "Store";
        selStoreNumber.DataSource = qryLocations.ToList();
        selStoreNumber.BindingContext = new BindingContext();
      }
    } //end populateStoreList

    private void populateProductList()
    {
      //populate Product List combobox
      string pathProducts = @"C:\Program Files\ITS\OrderBuilder\builderSettings.xml";
      if (File.Exists(pathProducts))
      {
        XDocument xDocProducts = XDocument.Load(pathProducts);
        var qryProducts = from products in xDocProducts.Descendants("product")
                          select new { ProductID = products.Attribute("id").Value, productName = products.Element("name").Value };

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
    }

    private void button2_Click(object sender, EventArgs e)
    {
      DialogResult result = openFileDialog2.ShowDialog();
      string file = openFileDialog2.FileName;
      jpgLocation.Text = file;
    } //end populateProductList

  }
}
