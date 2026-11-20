using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Specialized;
using System.Windows.Forms; 

namespace Newsfeed_Manager.datasources
{
    public class Filemanager : datenInterface
    {
        public void schreibeDaten(List<wrpNewsfeed> newsliste)
        {
            StreamWriter sw = new StreamWriter(Application.UserAppDataPath+"\\daten.txt", false, Encoding.UTF8);
            // object des streamwriters in form von daten.txt, append yes, encoding utf8

            //Alle Inhalte von Feeds mit Delimiter-Trennung  / Category | Title | Pub_date | Author | Content 
            string zeile;
            foreach (wrpNewsfeed item in newsliste)
            {
                sw.WriteLine(item.Category + "|" + item.Title + "|" + item.Content);
            }
            sw.Close();
        }

        public List<wrpNewsfeed> leseDaten()
        {
            List<wrpNewsfeed> newsfeeds = new List<wrpNewsfeed>();
            StreamReader sr = new StreamReader(Application.UserAppDataPath+"\\daten.txt", Encoding.UTF8);

           
            while (!sr.EndOfStream)
            {
                string zeile = sr.ReadLine();
                string[] teile = zeile.Split('|');

                wrpNewsfeed item = new wrpNewsfeed();
                item.Category = teile[0];
                item.Title = teile[1];
                item.Content = teile[2];
                newsfeeds.Add(item);
            }

            sr.Close();
            return newsfeeds;
        }
       
        

    }

}
