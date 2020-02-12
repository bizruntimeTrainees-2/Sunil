using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    static class Update
    {
        public static void update()
        {
            string db = "Data source=.; database=Help; integrated security= SSPI";
            SqlConnection sqlConnection = new SqlConnection(db);
            try
            {
                string updateString = @"update Help.dbo.Categories
	                                    set CompanyName = 'Orac'
	                                    where CompanyName = 'Tech'";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(updateString, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Data Updated");
                try
                {
                    sqlConnection.Close();
                }
                catch (SqlException sq)
                {
                    Console.WriteLine(sq.ToString());
                }
            }
        }
    }
}
