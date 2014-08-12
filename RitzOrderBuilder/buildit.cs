using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.Drawing;
using System.Drawing.Printing;
using Microsoft.Win32;

namespace RitzOrderBuilder
{
  public class buildit
  {
    public void builder(Form1 form)
    {
      string storeNum = form.lblStoreNum.Text;
      int apmId = Convert.ToInt32(storeNum) + 16000;
      string apm_id = apmId.ToString();
      string firstName = form.custFirstName.Text;
      string lastName = form.custLastName.Text;
      string phone = form.custPhone.Text;
      string email = form.custEmail.Text;
      string pdfLocation = form.PDFLocation.Text;
      string originalPdfName = pdfLocation.Split('\\').Last();
      //need to fix pdf name for order imposition script. The script uses _001 to set the job
      // index. Since there will only be 1 pdf per order for now, hard coding it will work.
      string pdfName = originalPdfName.Replace(".pdf", "_001.pdf");
      string jpgLocation = form.jpgLocation.Text;
      string jpgName = jpgLocation.Split('\\').Last();
      string productId = Convert.ToString(form.productList.SelectedValue);
      var productInfo = getProductName(productId);
      string productName = productInfo.Item1;
      string coverId = productInfo.Item2;
      string coverName = productInfo.Item3;

      string qty = Convert.ToString(form.quantity.Text);
      string orderNum = createOrderNum(storeNum);
      string pageCount = form.pageCount.Text;
      string orderTotalWithDol = form.orderTotal.Text;
      string orderTotal = orderTotalWithDol.Replace("$", "");
      decimal intLineItemTotal = Convert.ToDecimal(orderTotal) / Convert.ToDecimal(qty);
      string lineItemTotal = intLineItemTotal.ToString();
      string extraPages = form.extraPages.Text;
      string extraPageCount = extraPages.Split(' ')[0];

      string storeCityStateZip = form.lblStoreCityStateZip.Text;
      string[] arrStoreCityStateZip = storeCityStateZip.Split(',');
      string storeCity = arrStoreCityStateZip[0].Trim();
      string storeState = arrStoreCityStateZip[1].Trim();
      string storeZip = arrStoreCityStateZip[2].Trim();

      string tempFolderName = orderNum + ".temp";
      string orderFolderPath = Path.Combine(@"C:\APM_TRANSFER\Orders\Outlab\", tempFolderName);
      createOrderFolder(orderFolderPath);

      copyOrderFiles(pdfLocation, orderFolderPath, pdfName);
      if (!String.IsNullOrEmpty(jpgLocation))
      {
        copyOrderFiles(jpgLocation, orderFolderPath, jpgName);
      }
      //Store store = new Store(storeNum);
      //start creating the order xml
      XDocument xDoc = new XDocument(
        new XDeclaration("1.0", "windows-1252", null),
        new XElement("apm_order",
          new XAttribute("apm_order_number", orderNum),
          new XAttribute("fulfillment_id", "pickup"),
          new XAttribute("items_total", orderTotal),
          new XAttribute("source", "express"),
          new XAttribute("status", "ordered"),
          new XAttribute("timestamp", DateTime.Now),
          new XAttribute("apm_build", "Touchprints (Rev. 31591)"),
          new XAttribute("apm_id", apm_id),
          new XAttribute("apm_xml_version", "2.0"),
          new XElement("shipment", "",
            new XAttribute("fulfillment_type", "pickup"),
            new XAttribute("delivery_method", ""),
            new XAttribute("shipment_id", "1"),
            new XAttribute("subtotal", orderTotal),
            new XAttribute("subtotal_items", orderTotal),
            new XAttribute("fname", firstName),
            new XAttribute("lname", lastName),
            new XAttribute("phone", phone),
            new XAttribute("email", email),
            new XAttribute("address1", ""),
            new XAttribute("address2", ""),
            new XAttribute("city", ""),
            new XAttribute("country", ""),
            new XAttribute("state", ""),
            new XAttribute("zip", ""),
            new XElement("order_item", "",
              new XAttribute("additional_units", extraPageCount),
              new XAttribute("description", productName),
              new XAttribute("name", productName),
              new XAttribute("product", productId),
              new XAttribute("price", orderTotal),
              new XAttribute("line_item_total", lineItemTotal),
              new XAttribute("for_fulfillment", "true"),
              new XAttribute("product_sub_type", "book"),
              new XAttribute("product_type", "folio"),
              new XAttribute("quantity", qty),
              new XAttribute("template_id", productId),
              new XElement("folio_render_mode", "rendered"),
              new XElement("attributes",
                new XAttribute("page_count", pageCount)),
              new XElement("image",
                new XAttribute("black_white", "false"),
                new XAttribute("borders", "false"),
                new XAttribute("fit_to_paper", "false"),
                new XAttribute("path", pdfName),
                new XAttribute("sepia", "false")
                )))));
      if (!String.IsNullOrEmpty(jpgLocation))
      {
        xDoc.Element("apm_order").Element("shipment").Add(new XElement("order_item",
          new XAttribute("description", coverName),
          new XAttribute("for_fulfillment", "true"),
          new XAttribute("name", coverName),
          new XAttribute("product", coverId),
          new XAttribute("price", "0.00"),
          new XAttribute("line_item_total", "0.00"),
          new XAttribute("template_id", coverId),
          new XAttribute("product_type", "folio"),
          new XAttribute("quantity", qty),
          new XAttribute("product_sub_type", "book"),
          new XElement("folio_render_mode", "rendered"),
          new XElement("attributes",
            new XAttribute("page_count", "1"),
            new XAttribute("upsold_from_product_id", productId)),
          new XElement("image",
            new XAttribute("black_white", "false"),
            new XAttribute("borders", "false"),
            new XAttribute("fit_to_paper", "false"),
            new XAttribute("path", jpgName),
            new XAttribute("sepia", "false"))
          ));
      }
   xDoc.Element("apm_order").Add(new XElement("attributes",
              new XAttribute("finish", "glossy")),
            new XElement("customer"),
            new XElement("store",
              new XAttribute("contact_email", form.lblStoreContactEmail.Text),
              new XAttribute("contact_name", form.lblStoreContact.Text),
              new XAttribute("store_address", form.lblStoreAddress.Text),
              new XAttribute("store_city", storeCity),
              new XAttribute("store_country", "US"),
              new XAttribute("store_id", storeNum),
              new XAttribute("store_name", form.lblStoreName.Text.Replace("&&", "&")),
              new XAttribute("store_state", storeState),
              new XAttribute("store_zip", storeZip))
        );


      xDoc.Save(Path.Combine(orderFolderPath, orderNum + ".xml"));
      string orderFolderReady = orderFolderPath.Replace("temp", "order");
      Directory.Move(orderFolderPath, orderFolderReady);

      string finishedMessage = "Order has been created and will be sent to the OutLab.\n\n";
      finishedMessage += "Order Number: " + orderNum;
      finishedMessage += "\nOrder Total: " + orderTotalWithDol;
      MessageBox.Show(finishedMessage);

      //print invoice to default printer
      string printData = string.Empty;
      if (form.chkPrint.Checked == true)
      {
        printData += "Store: " + storeNum;
        printData += "\n\nOrder Number: " + orderNum;
        printData += "\nOrder Total: " + orderTotalWithDol;
        printData += "\n\nProduct: " + productName;
        printData += "\nQuantity: " + qty;
        printData += "\nPDF Name: " + originalPdfName;
        printData += "\nJPG Name: " + jpgName;
        printData += "\nPage Count: " + pageCount;
        printData += "\nAdditional Pages: " + extraPages;
        printData += "\n\nCustomer Information";
        printData += "\nName: " + firstName + " " + lastName;
        printData += "\nPhone: " + phone;
        printData += "\nEmail: " + email;

        PrintDocument printDoc = new PrintDocument();
        printDoc.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
        {
          e1.Graphics.DrawString(printData, new Font("Times New Roman", 14),
            new SolidBrush(Color.Black),
            new RectangleF(30.6F, 30.7F, printDoc.DefaultPageSettings.PrintableArea.Width, printDoc.DefaultPageSettings.PrintableArea.Height));
        };
        try
        {
          printDoc.Print();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Unable to print invoice.\n" + ex.ToString());
        }
      }

      //log the order
      string logPath = @"C:\Program Files\ITS\OrderBuilder\OrderLog.xml";
      DateTime logTime = DateTime.Now;
      string datePatt = @"M/d/yyyy hh:mm:ss tt";
      string strLogTime = logTime.ToString(datePatt);
      if (!File.Exists(logPath))
      {
        XDocument xLogDoc = new XDocument(
        new XDeclaration("1.0", "windows-1252", null),
        new XElement("orders", ""));
        xLogDoc.Save(logPath);
      }
      clearOldLogs();
      XElement xLogOrder = XElement.Load(logPath);
      xLogOrder.Add(new XElement("order",
        new XAttribute("order_number", orderNum),
        new XAttribute("timestamp", strLogTime),
          new XElement("order_total", orderTotal),
          new XElement("product", productName),
          new XElement("quantity", qty),
          new XElement("pdf_name", originalPdfName),
          new XElement("jpg_name", jpgName),
          new XElement("page_count", pageCount),
          new XElement("extra_pages", extraPageCount),
          new XElement("customer_info", 
            new XElement("first_name", firstName),
            new XElement("last_name", lastName),
            new XElement("phone", phone),
            new XElement("email", email))));
      xLogOrder.Save(logPath);
    } //end builder

    private void clearOldLogs()
    {
      string logPath = @"C:\Program Files\ITS\OrderBuilder\OrderLog.xml";

      DateTime oldestOrder = DateTime.Today.AddDays(-30);

      XElement xOrders = XElement.Load(logPath);
      //IEnumerable<XElement> orders = xOrders.Elements();
      var orders = xOrders.Elements("order").ToList();
      foreach (XElement order in orders)
      {
        DateTime orderDate = Convert.ToDateTime(order.Attribute("timestamp").Value);
        if (DateTime.Compare(orderDate, oldestOrder) < 0)
        {
          order.Remove();
        }
      }
      xOrders.Save(logPath);
    } //end clearOldLogs

    private void createOrderFolder(string orderFolderPath)
    {
      try
      {
        if (!Directory.Exists(orderFolderPath))
        {
          DirectoryInfo di = Directory.CreateDirectory(orderFolderPath);
        }
      }
      catch(Exception e)
      {
        MessageBox.Show("Unable to create order folder.\n" + e.ToString());
      }
    } //end createOrderFolder

    private void copyOrderFiles(string originalFile, string orderFolderPath, string pdfName)
    {
      try
      {
        if (Directory.Exists(orderFolderPath))
        {
          File.Copy(originalFile, Path.Combine(orderFolderPath, pdfName), true);
        }
      }
      catch (Exception e)
      {
        MessageBox.Show("Unable to copy file to order folder.  Make sure the file exists.\n" + e.ToString());
      }
    } //end copyOrderFiles

    private Tuple<string,string,string> getProductName(string productId)
    {
      string pathProducts = @"C:\Program Files\ITS\OrderBuilder\builderSettings.xml";
      string productName = string.Empty;
      string coverId = string.Empty;
      string coverName = string.Empty;
      if (File.Exists(pathProducts))
      {
        XDocument xDocProducts = XDocument.Load(pathProducts);
        var qryProducts = from products in xDocProducts.Descendants("product")
                          where (string)products.Attribute("id").Value == productId
                          select products;
        
        foreach (var item in qryProducts)
        {
          productName = item.Attribute("name").Value;
          if (item.Element("cover") != null)
          {
            coverId = item.Element("cover").Attribute("id").Value;
            coverName = item.Element("cover").Attribute("name").Value;
          }
        }
      }
      return Tuple.Create(productName, coverId, coverName);
    } //end getProductName

    private static string createOrderNum(string storeNum)
    {
      int store = Convert.ToInt32(storeNum) + 16000;
      //DateTime curDateTime = DateTime.Now;
      //string strDateTime = curDateTime.ToString("MMddHHmmss");
      Random r = new Random();
      int rndNum = r.Next(10000, 30000);
      //string orderNum = store.ToString() + rndNum;
      int orderID = 00000;

      RegistryKey orderKey = Registry.CurrentUser.CreateSubKey("Software\\ITS\\OrderBuilder");
      string lastNum = (string) orderKey.GetValue("orderID");
      if (lastNum == null)
      {
        orderKey.SetValue("orderID", rndNum, RegistryValueKind.String);
        orderID = rndNum;
      }
      else
      {
        orderID = Convert.ToInt32(lastNum) + 1;
        orderKey.SetValue("orderID", orderID, RegistryValueKind.String);
      }
      string orderNum = store.ToString() + orderID.ToString();
      return orderNum;
    } //end createOrderNum
  } //end buildit
}