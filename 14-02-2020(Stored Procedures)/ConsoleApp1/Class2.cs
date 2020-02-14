using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Class2
    {
        public static void storedProcedure()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ComputerShop;Integrated Security=True");
            string query =
              @"
                select SPECIFIC_NAME from ComputerShop.information_schema.routines where routine_type = 'PROCEDURE'
            ";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["SPECIFIC_NAME"].ToString());
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}