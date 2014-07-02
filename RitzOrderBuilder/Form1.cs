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
      //Get the latest version of orderbuilder.xml
      string urlLocations = "http://ritzpix.com/media/files/orderbuilder.xml";
      string pathLocations = @"C:\APM\orderbuilder.xml";

      Uri url = new Uri(urlLocations);
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
      HttpWebResponse response = (HttpWebResponse)request.GetResponse();
      response.Close();
      Int64 iSize = response.ContentLength;
      Int64 iRunningByteTotal = 0;

      using (WebClient client = new WebClient())
      {
        using (Stream streamRemote = client.OpenRead(new Uri(urlLocations)))
        {
          using (Stream streamLocal = new FileStream(pathLocations, FileMode.Create, FileAccess.Write, FileShare.None))
          {
            int iByteSize = 0;
            byte[] byteBuffer = new byte[iSize];
            while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
            {
              streamLocal.Write(byteBuffer, 0, iByteSize);
              iRunningByteTotal += iByteSize;

              double dIndex = (double)(iRunningByteTotal);
              double dTotal = (double)byteBuffer.Length;
              double dProgressPercentage = (dIndex / dTotal);
              int iProgressPercentage = (int)(dProgressPercentage * 100);

              backgroundWorker1.ReportProgress(iProgressPercentage);
            }
            streamLocal.Close();
          }
          streamRemote.Close();
        }
      }
    } //end backgroundWorker1_DoWork

    private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      this.lblDownloading.Text = (e.ProgressPercentage.ToString() + "%");
    } //end backgroundWorker1_ProgressChanged

    private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (!(e.Error == null))
      {
        this.lblDownloading.Text = "Could not download store information.  " + e.Error.Message;
      }
      else
      {
        lblDownloading.Visible = false;
        populateStoreList();
      }
    } //end backgroundWorker1_RunWorkerCompleted

    private void populateStoreList()
    {
      //populate store number combobox
      string pathLocations = @"C:\Program Files\ITS\OrderBuilder\buildersettings.xml";
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
    }
  }
}
