using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace RitzOrderBuilder
{
  public class Store
  {
    public string name, email, address, city, state, zip, contactName;

    public Store(string storeNum)
    {
      string pathLocations = @"C:\Program Files\ITS\OrderBuilder\ritzsetup.xml";
      if (File.Exists(pathLocations))
      {
        XDocument xDocLocations = XDocument.Load(pathLocations);
        var qryLocations = from locations in xDocLocations.Descendants("location")
                           where (string)locations.Attribute("store_number").Value == storeNum
                           select locations;

        foreach (var item in qryLocations)
        {
          name = item.Attribute("store_name").Value;
          email = item.Attribute("contact_email").Value;
          address = item.Attribute("store_address").Value;
          city = item.Attribute("store_city").Value;
          state = item.Attribute("state").Value;
          zip = item.Attribute("store_zip").Value;
          contactName = item.Attribute("contact_name").Value;
        }
      }
    } //end Store
  }
}