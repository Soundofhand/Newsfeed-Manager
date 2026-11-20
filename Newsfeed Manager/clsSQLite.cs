using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newsfeed_Manager.datasources
{
    internal class clsSQLite2 : datenInterface
    {
        public List<wrpNewsfeed> leseDaten()
        {

            List<wrpNewsfeed> newsfeeds = new List<wrpNewsfeed>();
        
            SQLiteConnection sqlcon = new SQLiteConnection(
            "Data Source=" + Application.UserAppDataPath + "\\daten.db;Version=3;");
            sqlcon.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM newsfeeds", sqlcon);

            SQLiteDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string title = sdr.GetString(1);
                string content = sdr.GetString(2);
                string category =  sdr.GetString(3);

                newsfeeds.Add(new wrpNewsfeed(){ Title = title, Content = content, Category = category });
            }

            sqlcon.Close();

            return newsfeeds;
        }

        public void schreibeDaten(List<wrpNewsfeed> newsliste)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(
            "Data Source=" + Application.UserAppDataPath + "\\daten.db;Version=3;");
            sqlcon.Open();
            SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS newsfeeds(" +
                "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                " title Text NOT NULL," +
                " content Text NOT NULL," +
                " category Text NOT NULL" +
                ")", sqlcon);
            // [] oder ´´ um Bezeichner zu leiten

            cmd.ExecuteNonQuery();

            new SQLiteCommand("DELETE FROM newsfeeds", sqlcon).ExecuteNonQuery();

            foreach(wrpNewsfeed item in newsliste)
            {
                SQLiteCommand cmditem = new SQLiteCommand("Insert into newsfeeds (" +
                    "title, content, category)" +
                    "VALUES('"+item.Title+"', '"+item.Content+"', '"+item.Category+"') ", sqlcon);

                cmditem.ExecuteNonQuery();
            }

            sqlcon.Close();
        }

        

    }
}
