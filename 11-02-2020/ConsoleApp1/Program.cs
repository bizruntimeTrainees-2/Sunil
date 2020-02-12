using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "data source=.;database= customers; integrated security= SSPI";
            SqlConnection sqlConnection = new SqlConnection(data);
            SqlDataReader rdr = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from customers.dbo.sales_customers1", sqlConnection);
                sqlConnection.Open();
                rdr = sqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }

        }
    }
}
