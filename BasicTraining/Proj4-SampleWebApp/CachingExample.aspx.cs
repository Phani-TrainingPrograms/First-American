using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class CachingExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            switch (Request.QueryString["City"])
            {
                case "New York":
                    lblCityTime.Text = DateTime.Now.AddHours(-15).ToLongTimeString();
                    break;
                case "New Delhi":
                    lblCityTime.Text = DateTime.Now.ToLongTimeString();
                    break;
                case "London":
                    lblCityTime.Text = DateTime.Now.AddHours(-5.5).ToLongTimeString();
                    break;
                case "Tokyo":
                    lblCityTime.Text = DateTime.Now.AddHours(4).ToLongTimeString();
                    break;
                default:
                    break;
            }
        }

        protected void dpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("CachingExample.aspx?City=" + dpList.Text);
        }
    }
}