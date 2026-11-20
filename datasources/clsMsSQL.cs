using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newsfeed_Manager.datasources
{
    internal class clsMsSQL : datenInterface
    {
        public List<wrpNewsfeed> leseDaten()
        {

            List<wrpNewsfeed> newsfeeds = new List<wrpNewsfeed>();
        
            SqlConnection sqlcon = new SqlConnection("Server=192.168.131.114;Database=newsfeeds;User Id=sa;Password=,leipzig;");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM newsfeeds", sqlcon);

            SqlDataReader sdr = cmd.ExecuteReader();
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
            SqlConnection sqlcon = new SqlConnection(
            "Server=192.168.131.114;Database=newsfeeds;User Id=sa;Password=,leipzig;");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("" +
                "IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'newsfeeds') BEGIN  " +
                "CREATE TABLE newsfeeds(" +
                "id INT NOT NULL IDENTITY(1,1) PRIMARY KEY," +
                " title VARCHAR(200) NOT NULL," +
                " content Text NOT NULL," +
                " category VARCHAR(100) NOT NULL" +
                ") END" , sqlcon);
                // [] oder ´´ um Bezeichner zu leiten

            cmd.ExecuteNonQuery();

            new SqlCommand("DELETE FROM newsfeeds", sqlcon).ExecuteNonQuery();

            foreach(wrpNewsfeed item in newsliste)
            {
                SqlCommand cmditem = new SqlCommand("Insert into newsfeeds (" +
                    "title, content, category)" +
                    "VALUES('"+item.Title+"', '"+item.Content+"', '"+item.Category+"') ", sqlcon);

                cmditem.ExecuteNonQuery();
            }

            sqlcon.Close();
        }

        

    }
}
