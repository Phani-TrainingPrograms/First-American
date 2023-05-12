using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace SampleWebApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["products"] = new ProductRepo().Products;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["recent"] = new Queue<Product>();
            Session["cart"] = new List<Product>();
        }
    }
}