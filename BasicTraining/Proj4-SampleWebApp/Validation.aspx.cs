using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class Validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if ((args.Value != "Developer") || (args.Value != "Tester"))
                args.IsValid = false;
            else
                args.IsValid = true;
        }
    }
}