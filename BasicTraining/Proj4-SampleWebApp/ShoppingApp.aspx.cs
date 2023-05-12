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
                //Populating the data into the Text boxes. 
                var id = Convert.ToInt32(e.CommandArgument);
                var data = Application["products"] as List<Product>;
                var selectedProduct = data.Find((p) => p.ProductId == id);
                lblItemId.Text = selectedProduct.ProductId.ToString();
                txtName.Text = selectedProduct.ProductName;
                txtPrice.Text 
                    = selectedProduct.ProductPrice.ToString();

                //Get the Session object.
                var recent = Session["recent"] as Queue<Product>;
                //Add the Item to the Recent Queue available in the session object. Add the Item to the Queue upto 5 in number
                if(recent.Count == 5)
                {
                    recent.Dequeue();//Removes the 1st item in the queue
                }
                recent.Enqueue(selectedProduct);
                dtRecent.DataSource = recent.Reverse();
                dtRecent.DataBind();
                //Populate to a Control to display the recent list
                //
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //Get the session
            //get the item details
            //add the item to the session

        }
    }
}