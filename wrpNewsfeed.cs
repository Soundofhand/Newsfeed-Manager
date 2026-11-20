using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsfeed_Manager
{
    [Serializable]
    public class wrpNewsfeed
    {

        private String _title;
        private String _content;
        private String _category;

        public String Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        public String Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        public String Category
        {
            get { return this._category; }
            set { this._category = value; }
        }
        public wrpNewsfeed() { }
    }
}
