using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class PreviousPageExample : System.Web.UI.Page
    {
        public TextBox NameProperty => txtName;
        public TextBox EmailProperty => txtEmail;
        public TextBox DoBProperty => txtDob;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
    }
}