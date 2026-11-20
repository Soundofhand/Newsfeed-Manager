using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Newsfeed_Manager.datasources
{
    internal class clsXML : datenInterface
    {

        public void schreibeDaten(List<wrpNewsfeed> newsliste)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNode root = xmldoc.CreateElement("feeds");

           
            foreach (wrpNewsfeed item in newsliste)
            {
                XmlNode feed = xmldoc.CreateElement("feed");

                XmlNode title = xmldoc.CreateElement("title");
                title.InnerText = item.Title;
                XmlNode content = xmldoc.CreateElement("content");
                content.InnerText = item.Content;
                XmlNode category = xmldoc.CreateElement("category");
                category.InnerText = item.Category;

                
                root.AppendChild(feed);
                feed.AppendChild(title);
                feed.AppendChild(content);
                feed.AppendChild(category);
            }

            xmldoc.AppendChild(root);

            xmldoc.Save(Application.UserAppDataPath + "\\daten.xml");

        }

        List<wrpNewsfeed> ausgabe = new List<wrpNewsfeed>();
        public List<wrpNewsfeed> leseDaten()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(Application.UserAppDataPath + "\\daten.xml");

            XmlNode root = xmldoc.DocumentElement;
            foreach (XmlNode item in root.ChildNodes)
            {
                XmlNode title = item.SelectSingleNode("title");
                XmlNode content = item.SelectSingleNode("content");
                XmlNode category = item.SelectSingleNode("category");

                ausgabe.Add(new wrpNewsfeed() { Title = title.InnerText, Content = content.InnerText, Category = category.InnerText });
            }

            return ausgabe;
        }
    }
}
