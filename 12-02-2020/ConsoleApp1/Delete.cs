using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    static class Delete
    {
        public static void delete()
        {
            string db = "Data Source=.; database=Help; integrated security=SSPI";
            SqlConnection sqlConnection = new SqlConnection(db);

            try
            {
                string deleteString = @"delete from Help.dbo.Categories
                                        where CompanyName= 'Orac'";
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(deleteString, sqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Data deleted");
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
