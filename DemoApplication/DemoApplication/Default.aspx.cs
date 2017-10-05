using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoApplication
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string createFolder()
        {
            string folderlocation = "C://" + DateTime.Now.ToString("MMddyyyy") ;

            if (!Directory.Exists(folderlocation))
            {
                // Try to create the directory.
                Directory.CreateDirectory(folderlocation);
            }
            return folderlocation;
        }
    }
}