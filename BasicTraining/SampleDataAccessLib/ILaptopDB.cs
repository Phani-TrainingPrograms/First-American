using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataAccessLib
{
    public interface ILaptopDB
    {
        void AddNewLaptop(LaptopInfo laptopInfo);
        void UpdateLaptop(LaptopInfo laptopInfo);
        void DeleteLaptop(int machineId);
        List<LaptopInfo> GetAllLaptops();
    }

    class LaptopDataComponent : ILaptopDB
    {
        private readonly string STRCONNECTION = @"Data Source=.\SQLEXPRESS;Initial Catalog=FaiTraining;Integrated Security=True";
        const string STRGETALL = "SELECT * FROM tblLaptop";
        const string STRUPDATE = "Update tblLaptop Set EmpName = @name, BrandName = @brand, SeriesName = @series, Price = @price Where EntryId = @id";
        const string STRDELETE = "Delete From tblLaptop where EntryId = @id";
        const string STRINSERT = "Insert into tblLaptop Values(@name, @brand, @series, @price)";

        public void AddNewLaptop(LaptopInfo laptopInfo)
        {
            //Create the Connection
            var connection = new SqlConnection(STRCONNECTION);
            //Create the Command
            var command = new SqlCommand(STRINSERT, connection);
            //Add parameters
            command.Parameters.AddWithValue("@name", laptopInfo.EmpName);
            command.Parameters.AddWithValue("@brand", laptopInfo.BrandName);
            command.Parameters.AddWithValue("@series", laptopInfo.Series);
            command.Parameters.AddWithValue("@price", laptopInfo.Price);
            try
            {
                //Open the connection
                connection.Open();
                //execute the NonQuery version
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            //Close the Connection
        }

        public void DeleteLaptop(int machineId)
        {
            throw new NotImplementedException();
        }

        public List<LaptopInfo> GetAllLaptops()
        {
            //Create a blank list of LaptopInfo
            var list = new List<LaptopInfo>();
            //create the connection
            var connection = new SqlConnection(STRCONNECTION);
            //create the command
            var command = new SqlCommand(STRGETALL, connection);
            //set the parameters if any
            try
            {
                //open the connection
                connection.Open();
                //execute the appropriate command
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var row = new LaptopInfo
                    {
                        EntryId = Convert.ToInt32(reader[0]),
                        EmpName = reader[1].ToString(),
                        BrandName = reader[2].ToString(),
                        Series = reader[3].ToString(),
                        Price = Convert.ToDouble(reader[4])
                    };
                    list.Add(row);
                }
            }
            catch (SqlException ex)
            {
                //Handle exceptions if any. 
                throw ex;
            }
            finally
            {
                //close the connection
                connection.Close();
            }
            return list;
        }

        public void UpdateLaptop(LaptopInfo laptopInfo)
        {
            var connection = new SqlConnection(STRCONNECTION);
            var command = new SqlCommand(STRUPDATE, connection);
            command.Parameters.AddWithValue("@name", laptopInfo.EmpName);
            command.Parameters.AddWithValue("@brand", laptopInfo.BrandName);
            command.Parameters.AddWithValue("@series", laptopInfo.Series);
            command.Parameters.AddWithValue("@price", laptopInfo.Price);
            command.Parameters.AddWithValue("@id", laptopInfo.EntryId);
            try
            {
                connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                if(rowsAffected != 1)
                {
                    throw new Exception("No record found to update");
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
