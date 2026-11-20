using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newsfeed_Manager
{
    public partial class subkategorie_control : UserControl
    {
        public subkategorie_control()
        {
            InitializeComponent();
            // Here be dragons
          //  kategorien_control_init();
        }

        public String Title
        {
            get { return this.subkategorie_control_label.Text; }
            set { this.subkategorie_control_label.Text = value; }
        }

        private void subkategorie_control_label_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }


        /* private void kategorien_control_init()
        {
            subkategorie_control_label.Text ="Placeholder";
        }
        */
    }
}
