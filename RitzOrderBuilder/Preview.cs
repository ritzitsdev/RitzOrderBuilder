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
  class Preview
  {
    public void buildPreview(Form1 form)
    {
      string storeNum = Convert.ToString(form.selStoreNumber.SelectedValue);
      string pdfLocation = form.PDFLocation.Text;
      string productId = Convert.ToString(form.productList.SelectedValue);
      int qty = Convert.ToInt32(form.quantity.Text);
      
      int pageCount = 0;
      if(File.Exists(pdfLocation)){
        pageCount = countPages(pdfLocation);
      }else{
        MessageBox.Show("PDF file not found.");
        return;
      }

      decimal basePrice = calculateBasePrice(pageCount, productId, qty);

      var additionalPageCount = countAdditionalPages(pageCount, productId, qty);
      int extraPageCount = additionalPageCount.Item1;
      decimal pricePerExtraPage = additionalPageCount.Item2;

      decimal totalPriceExtraPages = extraPageCount * pricePerExtraPage;
      decimal orderTotal = (basePrice + totalPriceExtraPages) * qty;

      //string orderNum = createOrderNum(storeNum);

      //form.orderNumber.Text = orderNum;
      form.pageCount.Text = pageCount.ToString();
      form.extraPages.Text = extraPageCount + " pages @ $" + pricePerExtraPage + " per page.";
      form.orderTotal.Text = "$" + orderTotal.ToString();

      form.btnPreview.Visible = false;
      form.btnCreateOrder.Visible = true;
      form.lblInstructions1.Visible = true;
      form.btnUpdateForm.Visible = true;
    } //end builder

    private static int countPages(string pdfLocation)
    {
      PdfReader pdfReader = new PdfReader(pdfLocation);
      int numberOfPages = pdfReader.NumberOfPages;
      pdfReader.Close();
      return numberOfPages;
    } //end countPages

    private static decimal calculateBasePrice(int pageCount, string productId, int qty)
    {
      decimal price = 0;
      string pathProducts = @"C:\Program Files\ITS\OrderBuilder\builderSettings.xml";
      if (File.Exists(pathProducts))
      {
        XDocument xDocProducts = XDocument.Load(pathProducts);
        var qryProducts = from products in xDocProducts.Descendants("product")
                          where (string)products.Attribute("id") == productId
                          select products;
        foreach (var item in qryProducts)
        {
          price = Convert.ToDecimal(item.Element("fulfillment_option").Attribute("base").Value);
        }

        var qryQtyPrices = from qty_prices in qryProducts.Descendants("qty_pricing")
                           select qty_prices;
        foreach(XElement qty_price in qryQtyPrices)
        {
          int qtyPriceLevel = Convert.ToInt32(qty_price.Attribute("min").Value);
          if(qty >= qtyPriceLevel){
            price = Convert.ToDecimal(qty_price.Attribute("price").Value);
          }
        }
      }
      return price;
    } //end calculateBasePrice

    private Tuple<int, decimal> countAdditionalPages(int pageCount, string productId, int qty)
    {
      string pathProducts = @"C:\Program Files\ITS\OrderBuilder\builderSettings.xml";
      int extraPages = 0;
      decimal pricePerPage = 0;
      if (File.Exists(pathProducts))
      {
        XDocument xDocProducts = XDocument.Load(pathProducts);
        var qryProducts = from products in xDocProducts.Descendants("product")
                          where (string)products.Attribute("id") == productId
                          select products;
        foreach (var item in qryProducts)
        {
          int base_page_num = Convert.ToInt32(item.Element("fulfillment_option").Attribute("base_page_num").Value);
          extraPages = pageCount - base_page_num;
          pricePerPage = Convert.ToDecimal(item.Element("fulfillment_option").Attribute("increment_price").Value);
        }

        var qryPricePerExtraPage = from pricePerExtraPage in qryProducts.Descendants("qty_pricing")
                                   select pricePerExtraPage;
        foreach(XElement per_page in qryPricePerExtraPage){
          int qtyPriceLevel = Convert.ToInt32(per_page.Attribute("min").Value);
          if(qty >= qtyPriceLevel){
            pricePerPage = Convert.ToDecimal(per_page.Attribute("increment_price").Value);
          }
        }
      }
      return Tuple.Create(extraPages, pricePerPage);
    } //end countAdditionalPages
  } //end preview
}
