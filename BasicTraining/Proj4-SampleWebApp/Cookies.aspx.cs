using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            //Cookies are represented as objects of a class called HTTPCOOKIE. Cookie object can store one value as Value Property or Multiple values as Values Collection. 
            HttpCookie cookie = new HttpCookie("MyCookies");
            cookie.Values.Add("name", txtName.Text);
            cookie.Values.Add("email", txtEmail.Text);
            cookie.Values.Add("dob", txtDob.Text);
            Response.Cookies.Add(cookie);
            Response.Redirect("RecipiantPage.aspx");
        }
    }
}