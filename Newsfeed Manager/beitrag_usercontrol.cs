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
    public partial class beitrag_usercontrol : UserControl
    {
        public beitrag_usercontrol()
        {
            InitializeComponent();
        }

        public String Title
        {
            get { return this.feed_title_label.Text; }
            set { this.feed_title_label.Text = value; }
        }

        public String Content
        {
            get { return this.feed_content_label.Text; }
            set { this.feed_content_label.Text = value; }
        }

       /* public String Category
        {
            get { return this.feed_content_label.Text; }
            set { this.feed_content_label.Text = value; }
        }
       */
    }
}
