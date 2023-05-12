using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class QueryStringPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Unnamed_Click(object sender, EventArgs e)
        {
            var queryUrl = $"RecipiantPage.aspx?Name={txtName.Text}&Email={txtEmail.Text}&dob={txtDob.Text}";
            Response.Redirect(queryUrl);//Response.Redirect is a server side version of any hyperlinks that U use in HTML. It allows to navigate to the specific page anywhere in the internet. 
        }
    }
}