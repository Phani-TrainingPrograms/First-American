using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class SessionExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //Session object is available in the Page class and can be used to store any kind of data in the form of Key-value pairs. 
            var data = new UserInfo
            {
                DateOfBirth = DateTime.Parse(txtDob.Text),
                Email = txtEmail.Text,
                Name = txtName.Text
            };
            if(Session["userinfo"] == null)
            {
                Session.Add("userinfo", data);//Add the data to the session
            }
            else
            {
                Session["userinfo"] = data;//Update the session
            }
            lblStatus.Text = "User info is stored! U can view the Session Data Stored at <a href='RecipiantPage.aspx'>RecipiantPage.aspx</a>";
        }
    }
}