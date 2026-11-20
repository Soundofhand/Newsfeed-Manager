using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Newsfeed_Manager.datasources
{
    internal class clsMySql : datenInterface
    {
        public List<wrpNewsfeed> leseDaten()
        {
            List<wrpNewsfeed> Newsfeeds = new List<wrpNewsfeed>();
        
            MySqlConnection sqlcon = new MySqlConnection(
            "Server = 192.168.131.53; Database = ADONE_News; Uid= Ha.Diecke; Pwd =KZYRB;");
            sqlcon.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Newsfeeds", sqlcon);

            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string title = sdr.GetString(0);
                string content = sdr.GetString(1);
                string category =  sdr.GetString(2);

                Newsfeeds.Add(new wrpNewsfeed(){ Title = title, Content = content, Category = category });
            }

            sqlcon.Close();

            return Newsfeeds;
        }

        public void schreibeDaten(List<wrpNewsfeed> newsliste)
        {
            MySqlConnection sqlcon = new MySqlConnection(
            "Server = 192.168.131.53; Database = ADONE_News; Uid= Ha.Diecke; Pwd =KZYRB;");
            sqlcon.Open();
            MySqlCommand cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS Newsfeeds(" +
                "id INT NOT NULL AUTO_INCREMENT PRIMARY KEY ," +
                " title Text NOT NULL," +
                " content Text NOT NULL," +
                " category Text NOT NULL" +
                ")", sqlcon);
            // [] oder ´´ um Bezeichner zu leiten

            cmd.ExecuteNonQuery();

            new MySqlCommand("DELETE FROM Newsfeeds", sqlcon).ExecuteNonQuery();
            byte[] bild = this.holeBild();

            foreach(wrpNewsfeed item in newsliste)
            {
                MySqlCommand cmditem = new MySqlCommand("Insert into Newsfeeds (" +
                    "Titel, Content, Kategorie, Bild)" +
                    "VALUES('"+item.Title+"', '"+item.Content+"', '"+item.Category + "', @bild)", sqlcon);

                cmditem.Parameters.AddWithValue("@bild", bild);
           

                cmditem.ExecuteNonQuery();
            }

            sqlcon.Close();
        }

        public byte[] holeBild()
        {
            // Lädt das Bild als bitmap-OPbjekt vom Dateisystem
           Bitmap bmp = new Bitmap(Application.UserAppDataPath + "\\bild.jpg");

            // erschaffe Speuicherpaltz,m umn das Bild als BinärStream abzuubilden
            using (MemoryStream memoryStream = new MemoryStream())
            {
                //Schribe das gesamte Bild in den Speicherberiehc des memorySteams
                bmp.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);


                //Gebe das gesamte bild in Form eines Byte-arrays zurück
                return memoryStream.ToArray();
            }
            return null;
        }
        

    }
}
