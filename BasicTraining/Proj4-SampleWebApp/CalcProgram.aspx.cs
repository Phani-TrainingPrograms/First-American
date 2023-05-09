using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class CalcProgram : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAnswer_Click(object sender, EventArgs e)
        {
            //Take the input values into numbers
            var num1 = double.Parse(txtFirstValue.Text);
            var num2 = double.Parse(txtSecondValue.Text);
            var operand = dpOptions.Text;
            var result = 0.0;
            switch (operand)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "X": result = num1 * num2; break;
                case "/": result = num1 / num2; break;
                default:
                    break;
            }
            //display the result in the label
            lblDisplay.Text = $"{result}";
        }
    }
}