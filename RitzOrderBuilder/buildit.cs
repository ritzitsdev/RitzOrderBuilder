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
      string firstName = form.custFirstName.Text;
      string lastName = form.custLastName.Text;
      string phone = form.custPhone.Text;
      string email = form.custEmail.Text;
      string pdfLocation = form.PDFLocation.Text;
      string jpgLocation = form.jpgLocation.Text;
      string productId = Convert.ToString(form.productList.SelectedValue);
      int qty = Convert.ToInt32(form.quantity.Text);
      
      int pageCount = 0;
      if(File.Exists(pdfLocation)){
        pageCount = countPages(pdfLocation);
      }else{
        MessageBox.Show("PDF file not found.");
      }
      //MessageBox.Show(Convert.ToString(pageCount));

      int basePrice = calculateBasePrice(pageCount, productId, qty);
    } //end builder

    private static int countPages(string pdfLocation)
    {
      PdfReader pdfReader = new PdfReader(pdfLocation);
      int numberOfPages = pdfReader.NumberOfPages;
      //MessageBox.Show(Convert.ToString(numberOfPages));
      return numberOfPages;
    } //end countPages

    private static int calculateBasePrice(int pageCount, string productId, int qty)
    {
      int price = 0;
      string pathProducts = @"C:\Program Files\ITS\OrderBuilder\builderSettings.xml";
      if (File.Exists(pathProducts))
      {
        XDocument xDocProducts = XDocument.Load(pathProducts);
        var qryProducts = from products in xDocProducts.Elements("order_builder").Elements("products")
                          where (string)products.Attribute("id") == productId
                            select products;
        foreach (var item in qryProducts)
        {
          price = Convert.ToInt32(item.Element("fulfillment_option").Attribute("base").Value);
        }
        var qryQtyPrices = from qty_prices in xDocProducts.Elements("order_builder").Elements("products")
                           where (string)qty_prices.Attribute("id") == productId
                           select qty_prices.Elements("fulfillment_option").Elements("qty_pricing");
        foreach(XElement qty_price in qryQtyPrices)
        {
          int qtyPriceLevel = Convert.ToInt32(qty_price.Attribute("min").Value);
          if(qty > qtyPriceLevel){
            price = Convert.ToInt32(qty_price.Attribute("price").Value);
          }
        }
      }
      return price;
    } //end calculateBasePrice
  }
}
