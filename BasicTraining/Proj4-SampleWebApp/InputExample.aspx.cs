using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class InputExample : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Trace.Write("This page is Initialized");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Trace.Write("This page is Loaded for the GET METHOD");
            }
            else
            {
                Trace.Write("This page is loaded for the POST METHOD");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var email = txtEmail.Text;
            var dob = DateTime.Parse(txtDate.Text);
            lblDisplay.Text = $"The Name is {name} with Email {email} and the Date of birth is {dob.ToLongDateString()}";
        }
    }
}