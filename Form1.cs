using Newsfeed_Manager.datasources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Newsfeed_Manager
{
    public partial class base_window : Form
    {

        List<wrpNewsfeed> lstNewsfeed = new List<wrpNewsfeed>();
        List<String> tmpCategory = new List<String>();
        List<String> tmpFeed = new List<String>();
        public base_window()
        {
            InitializeComponent();

            lstNewsfeed.Add(new wrpNewsfeed() { Title = "Feed 1", Content = "In Monaten mit W lässt sich der blaue Otter nur ungern melken.", Category = "Schlagzeilen" });
            lstNewsfeed.Add(new wrpNewsfeed() { Title = "Feed 2", Content = "Fliegenfischen nun illegal, sagte Sprecher der Fliegeträger", Category = "IT-News" });
            lstNewsfeed.Add(new wrpNewsfeed() { Title = "Feed 3", Content = "blubb", Category = "IT-News" });

            foreach (wrpNewsfeed item in lstNewsfeed)
            {
                if (!tmpCategory.Contains(item.Category))
                {
                    this.addCategory(item.Category);
                    this.tmpCategory.Add(item.Category);
                }
            }
            this.save();
            this.read();


        }

        private void refreshfeeds(String cat)
        {
            List<wrpNewsfeed> filtered = this.lstNewsfeed;
            if (cat != "")
            {
                filtered = lstNewsfeed.FindAll(c => c.Category == cat).ToList();
            }
            this.news_panel.Controls.Clear();

            foreach (wrpNewsfeed item in filtered)
            { 
                this.addNewsfeed(item.Title, item.Content);            
            }
        }

        //Neu mit Linq
        // var ergebnis = lstNewsfeed.Select(item => item.Category).Distinct();


        private void new_kategorien_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addCategory("Sauce");
        }

        private void addCategory(String title)
        {
            subkategorie_control category = new subkategorie_control();
            category.Click += Category_Click;
            category.Dock = DockStyle.Top;
            category.Title = title;
            this.subkategorien_panel.Controls.Add(category);
            category.BringToFront();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            Console.WriteLine(((subkategorie_control)sender).Title);
            this.refreshfeeds(((subkategorie_control)sender).Title);
        }

        //Unfinished // Right side News Control
        private void addNewsfeed(String title, String content)
        {
            beitrag_usercontrol feed = new beitrag_usercontrol();
            feed.Dock = DockStyle.Top;
            feed.Title = title;
            feed.Content = content;
            // feed.aendern = null;
            this.news_panel.Controls.Add(feed);
            feed.BringToFront();
        }

        private void neuen_beitrag_hinzufuegen_panel_Click(object sender, EventArgs e)
        {
            addNewsfeed("yes","no");
        }

        public void save() {
            datenInterface file = this.getdatasource();
            file.schreibeDaten(lstNewsfeed);
        }

        public void read() {
            datenInterface file = this.getdatasource();
            this.refreshfeeds("");
            this.lstNewsfeed = file.leseDaten();
        }

        private string type = "MYSQL";
        public datenInterface getdatasource() {
            
            datenInterface file = null;

            switch (type)
            {
                case "XML":
                    file = new clsXML();
                    break;
                case "TXT":
                    file = new Filemanager();
                    break;
                case "BINARY":
                    file = new clsBinary();
                    break;
                case "SQLITE":
                    file = new clsSQLite();
                    break;
                case "MSSQL":
                    file = new clsMsSQL();
                    break;
                case "MYSQL":
                    file = new clsMySql();
                    break;
            }
            return file;
        }

        private void alleaenderungenspeichern_clickevent(object sender, EventArgs e)
        {
            this.save();
        }

        // Dropdownmenuclickevents
        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.type = "TXT";
        }
        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.type = "XML";
        }
        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.type = "BINARY";
        }
        private void sQLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.type = "SQLITE";
        }
        private void msSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.type = "MSSQL";
        }
        private void mySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.type = "MYSQL";
        }
        // Ende Dropdownmenuclickevents
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void write_changes_clickevent(object sender, EventArgs e)
        {

        }

        private void subkategorie_control2_Load(object sender, EventArgs e)
        {

        }



        private void subkategorie_control1_Load(object sender, EventArgs e)
        {

        }

        private void subkategorie_control1_Load_1(object sender, EventArgs e)
        {

        }


    }
}
