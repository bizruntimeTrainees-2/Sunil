using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    static class SqlCommandObject
    {
        public static void commandObject()
        {
            string db = "Data Source= .;database=Help;integrated security=SSPI";
            SqlConnection sqlConnection = new SqlConnection(db);
            try
            {               
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from Help.dbo.Categories;", sqlConnection);
                SqlDataReader rdr = sqlCommand.ExecuteReader();
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
                Console.WriteLine("Getting data from the Table");
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
