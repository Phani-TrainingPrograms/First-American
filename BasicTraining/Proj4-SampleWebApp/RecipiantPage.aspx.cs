using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class RecipiantPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /****************************Querystring Reading**********************************
            // 
            var name = Request.QueryString["Name"];
            var email = Request.QueryString["Email"];
            var dob = Request.QueryString["dob"];
            TimeSpan span = DateTime.Now - DateTime.Parse(dob);
            var age = (int)(span.TotalDays /365.25);

            var msg = $"The Name is {name}<br/>The Email Address is {email}<br/>The Age is {age} as per the Date of Birth mentioned as {dob}";
            lblDisplay.Text = msg;
            //Limitations: Querystring is not safe, it can be viewed by all other users of the machine and is available in the History of the browser. Some Browsers restrict the length of the URL upto 255 charecters and it can have only Text. 
            *******************************Cookies Reading*********************************
            //Cookies can be extracted from the Request Object's Cookies Property. 
            if(Request.Cookies["MyCookies"] == null)
            {
                lblDisplay.Text = "This Page is directly Viewed without Setting the cookie, Please visit the Cookies.aspx and set the cookie to see it";
                return;
            }
            var name = Request.Cookies["MyCookies"].Values["name"];
            var email = Request.Cookies["MyCookies"].Values["email"];
            var dob = Request.Cookies["MyCookies"].Values["dob"];
            TimeSpan span = DateTime.Now - DateTime.Parse(dob);
            var age = (int)(span.TotalDays / 365.25);

            var msg = $"The Name is {name}<br/>The Email Address is {email}<br/>The Age is {age} as per the Date of Birth mentioned as {dob}";
            lblDisplay.Text = msg;
            *******************************Previous Page Reading****************************
            //Every Page object will have the reference of the PreviousPage if the PreviousPage Directive is set. 
            if(PreviousPage == null)
            {
                lblDisplay.Text = "This Page is directly Viewed without going to the Previous Page, Please visit the PreviousPageExample.aspx and set the values to see it";
                return;
            }
            var name = PreviousPage.NameProperty.Text;
            var email = PreviousPage.EmailProperty.Text;
            var dob = PreviousPage.DoBProperty.Text;
            TimeSpan span = DateTime.Now - DateTime.Parse(dob);
            var age = (int)(span.TotalDays / 365.25);

            var msg = $"The Details from the Previous Page<br/>The Name is {name}<br/>The Email Address is {email}<br/>The Age is {age} as per the Date of Birth mentioned as {dob}";
            lblDisplay.Text = msg;
            *****************************************Retrieving Session Data****************************************/

            if(Session["userinfo"] != null)
            {
                
                var userInfo = Session["userinfo"] as UserInfo;//UNBOX
                var name = userInfo.Name;
                var email = userInfo.Email;
                var dob = userInfo.DateOfBirth.ToString("dd/MM/yyyy");
                TimeSpan span = DateTime.Now - userInfo.DateOfBirth;
                var age = (int)(span.TotalDays / 365.25);

                var msg = $"The Details from the Session are:<br/>The Name is {name}<br/>The Email Address is {email}<br/>The Age is {age} as per the Date of Birth mentioned as {dob}";
                lblDisplay.Text = msg;
            }
            else
            {
                lblDisplay.Text = "No info is stored";
            }
        }
    }
}