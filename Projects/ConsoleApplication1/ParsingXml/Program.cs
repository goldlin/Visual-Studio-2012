using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ParsingXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
            {
                Console.WriteLine(xmlNode.Attributes["currency"].Value + ": " + xmlNode.Attributes["rate"].Value);
            }

            xmlDoc.LoadXml("<users><user>InnerText/InnerXml is here</user></users>");
            Console.WriteLine("InnerXml: " + xmlDoc.DocumentElement.InnerXml);
            Console.WriteLine("InnerText: " + xmlDoc.DocumentElement.InnerText);
            Console.WriteLine("OuterXml: " + xmlDoc.DocumentElement.OuterXml);

            xmlDoc.Load("http://rss.cnn.com/rss/edition_world.rss");
            XmlNode titleNode = xmlDoc.SelectSingleNode("//rss/channel/title");
            if(titleNode != null)
                Console.WriteLine(titleNode.InnerText);

            XmlNodeList itemNodes = xmlDoc.SelectNodes("//rss/channel/item");
            foreach (XmlNode itemNode in itemNodes)
            {
                XmlNode title = itemNode.SelectSingleNode("title");
                XmlNode date = itemNode.SelectSingleNode("pubDate");
                if ((title != null) && (date != null))
                {
                    Console.WriteLine(date.InnerText + ": " + title.InnerText);
                }
            }
            Console.ReadKey();
        }
    }
}
