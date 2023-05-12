using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class ShoppingApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Extract the Application Data
                var data = Application["products"] as List<Product>;
                rpProducts.DataSource = data;
                rpProducts.DataBind();
            }
        }

        protected void rpProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName.ToUpper() == "SELECT")
            {
                var id = Convert.ToInt32(e.CommandArgument);
                var data = Application["products"] as List<Product>;
                var selectedProduct = data.Find((p) => p.ProductId == id);
                lblItemId.Text = selectedProduct.ProductId.ToString();
                txtName.Text = selectedProduct.ProductName;
                txtPrice.Text 
                    = selectedProduct.ProductPrice.ToString();
            }
        }
    }
}