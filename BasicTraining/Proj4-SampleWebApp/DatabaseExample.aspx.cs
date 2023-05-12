using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;//For DataSets and DataTables
using System.Data.SqlClient;//For SQL Server database connections
namespace SampleWebApp
{
    public partial class DatabaseExample : System.Web.UI.Page
    {
        static DataSet ds = new DataSet("myData");
        const string STRCONNECTION = @"Data Source=.\SQLEXPRESS;Initial Catalog=FaiTraining;Integrated Security=True";
        const string STRSELECT = "Select * from tblEmployee";
        static SqlDataAdapter ada = new SqlDataAdapter(STRSELECT, STRCONNECTION);
        static SqlCommandBuilder cb = new SqlCommandBuilder(ada);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                displayNames();
        }

        private void displayNames()
        {
                ds.Tables.Clear();
                ada.Fill(ds, "myEmpList");//Fill is a Smart method which opens the Connection, fills the data into the dataSet and immediately closes the Connection. DataSet is a in-memory object which has a collection of DataTable objects where each DataTable object represents the result of the SELECT Query of the Command. 
            foreach (DataRow row in ds.Tables["myEmpList"].Rows)
            {
                lstNames.Items.Add(new ListItem { Text = row["EmpName"].ToString(), Value = row[0].ToString() });
            }
            
        }

        protected void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ds.Tables.Count == 1)//Data has been filled into a table
            {
                var selectedId = int.Parse(lstNames.SelectedValue);
                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    if(Convert.ToInt32(row[0]) == selectedId)//Got the row
                    {
                        txtId.Text = row[0].ToString();
                        txtName.Text = row[1].ToString();
                        txtPhone.Text = row[2].ToString();
                        txtSalary.Text = row[3].ToString();
                        return;
                    }
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Find the matching record in the dataTable of the dataset
            try
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i][0].ToString() == txtId.Text)
                    {
                        //make the changes to the row..
                        ds.Tables[0].Rows[i][1] = txtName.Text;
                        ds.Tables[0].Rows[i][2] = txtPhone.Text;
                        ds.Tables[0].Rows[i][3] = txtSalary.Text;
                        ada.Update(ds, "myEmpList");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }    
            //Update the Database using the adapter
            //exit the function...

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Create a blank row object with the schema of the table
            var row = ds.Tables[0].NewRow();
            //Fill the values to the row from the inputboxes.
            row[1] = txtName.Text;
            row[2] = txtPhone.Text;
            row[3] = txtSalary.Text;
            row[4] = 3;
            row[5] = 8;
            //Add the row to the Table's Rows Collection
            ds.Tables[0].Rows.Add(row);
            //Update Fn from the ada. 
            ada.Update(ds, "myEmpList");
        }
    }
}