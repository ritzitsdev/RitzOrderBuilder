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

namespace RitzOrderBuilder
{
  public class buildit
  {
    public void builder(Form1 form)
    {
      string storeNum = Convert.ToString(form.selStoreNumber.SelectedValue);
      int apmId = Convert.ToInt32(storeNum) + 16000;
      string apm_id = apmId.ToString();
      string firstName = form.custFirstName.Text;
      string lastName = form.custLastName.Text;
      string phone = form.custPhone.Text;
      string email = form.custEmail.Text;
      string pdfLocation = form.PDFLocation.Text;
      string pdfName = pdfLocation.Split('\\').Last();
      //need to fix pdf name for order imposition script. The script uses _001 to set the job
      // index. Since there will only be 1 pdf per order for now, hard coding it will work.
      pdfName = pdfName.Replace(".pdf", "_001.pdf");
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

      string tempFolderName = orderNum + ".temp";
      string orderFolderPath = Path.Combine(@"C:\APM_TRANSFER\Orders\Outlab\", tempFolderName);
      createOrderFolder(orderFolderPath);

      copyOrderFiles(pdfLocation, orderFolderPath, pdfName);
      copyOrderFiles(jpgLocation, orderFolderPath, jpgName);
      Store store = new Store(storeNum);
      //start creating the order xml
      XDocument xDoc = new XDocument(
        new XDeclaration("1.0", "windows-1252", null),
        new XElement("apm_order", "",
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
              new XElement("attributes", "",
                new XAttribute("page_count", pageCount)),
              new XElement("image", "",
                new XAttribute("black_white", "false"),
                new XAttribute("borders", "false"),
                new XAttribute("fit_to_paper", "false"),
                new XAttribute("path", pdfName),
                new XAttribute("sepia", "false")
                )),
            new XElement("order_item", "",
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
              new XElement("attributes", "",
                new XAttribute("page_count", "1"),
                new XAttribute("upsold_from_product_id", productId)),
              new XElement("image", "",
                new XAttribute("black_white", "false"),
                new XAttribute("borders", "false"),
                new XAttribute("fit_to_paper", "false"),
                new XAttribute("path", jpgName),
                new XAttribute("sepia", "false"))
              )),
            new XElement("attributes", "",
              new XAttribute("finish", "glossy")),
            new XElement("customer", ""),
            new XElement("store", "",
              new XAttribute("contact_email", store.email),
              new XAttribute("contact_name", store.contactName),
              new XAttribute("store_address", store.address),
              new XAttribute("store_city", store.city),
              new XAttribute("store_country", "US"),
              new XAttribute("store_id", storeNum),
              new XAttribute("store_name", store.name),
              new XAttribute("store_state", store.state),
              new XAttribute("store_zip", store.zip))
        ));
      xDoc.Save(Path.Combine(orderFolderPath, orderNum + ".xml"));
      string orderFolderReady = orderFolderPath.Replace("temp", "order");
      Directory.Move(orderFolderPath, orderFolderReady);

      string finishedMessage = "Order has been created and will be sent to the OutLab.\n\n";
      finishedMessage += "Order Number: " + orderNum;
      finishedMessage += "\nOrder Total: " + orderTotalWithDol;
      MessageBox.Show(finishedMessage);
    } //end builder

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
          coverId = item.Element("cover").Attribute("id").Value;
          coverName = item.Element("cover").Attribute("name").Value;
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
      int rndNum = r.Next(10000, 99999);
      string orderNum = store.ToString() + rndNum;
      return orderNum;
    } //end createOrderNum
  } //end buildit
}
