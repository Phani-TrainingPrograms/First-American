using System;
using System.Data.SqlClient;
using System.Data;
namespace Proj2_DataAccessProgram
{
    class Ex01_SingleTierApp
    {
        const string STRCONNECTION = @"Data Source=.\Sqlexpress;Initial Catalog=FaiTraining;Integrated Security=True";
        const string SELECTALL = "SELECT * FROM TBLEMPLOYEE";
        static void Main(string[] args)
        {
            //readRecordsFromDb();
            //insert the record
            //insertRecord("karthikeyan", 9876556445, 65000, 3, 5);

            //insertRecordUsingStoredProc("Veeresh", 9123456743, 70000, 2, 6);
            //deleteRecord(1024);
        }

        private static void deleteRecord(int recId)
        {
            const string STRDELETE = "DeleteEmployee";
            var con = new SqlConnection(STRCONNECTION);
            var cmd = new SqlCommand(STRDELETE, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empId", recId);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private static void insertRecordUsingStoredProc(string name, long phone, int salary, int dept, int city)
        {
            int iGeneratedId = 0;
            const string STRINSERT = "InsertEmployee";
            var con = new SqlConnection(STRCONNECTION);
            var cmd = new SqlCommand(STRINSERT, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empName", name);
            cmd.Parameters.AddWithValue("@empSalary", salary);
            cmd.Parameters.AddWithValue("@empPhone", phone);
            cmd.Parameters.AddWithValue("@deptId", dept);
            cmd.Parameters.AddWithValue("@cityId", city);
            cmd.Parameters.AddWithValue("@empId", iGeneratedId);
            cmd.Parameters[5].Direction = ParameterDirection.Output;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("The Generated Id is " + cmd.Parameters[5].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private static void insertRecord(string name, long phone, int salary, int dept, int city)
        {
            var statement = $"Insert into tblEmployee values('{name}', {phone}, {salary}, {dept}, {city})";
            var con = new SqlConnection(STRCONNECTION);
            var cmd = new SqlCommand(statement, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        
        }

        private static void readRecordsFromDb()
        {
            //A Class to connect to DB
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = STRCONNECTION;
            try
            {
                sqlCon.Open();//Connects to the database..
                //A Class to execute Queries to the database
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//Association of Cmd with Con...
                sqlCmd.CommandText = SELECTALL;
                //If we need to extract the data from the DB, we need a Reader object
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["EmpName"]);
                }
            }
            catch(SqlException ex)
            {
                UIConsole.PrintError(ex.Message);
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }
}
