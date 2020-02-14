using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    static class Class1
    {
        public static void storedProcedure()
        {
            string db = "Data Source=.; database=ComputerShop; integrated security=SSPI";
            SqlConnection con = new SqlConnection(db);
            string query =
                @"
                    CREATE PROCEDURE Insert_Record_procedure(
                        @Name varchar(50),
                        @Price varchar(50),
                        @Data DATETIME
                    )
                    AS  INSERT INTO Products(Name,Price,Date) Values(@Name,@Price,@Date)
                 ";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Stored Procedure Created Successfully");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                try
                {
                    con.Close();
                }
                catch(SqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
