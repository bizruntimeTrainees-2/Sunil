using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    static class InsertData
    {
        public static void insertData()
        {
            string db = "Data Source=.; database=Help; integrated security=SSPI";
            SqlConnection sqlConnection = new SqlConnection(db);
            try
            {
                String InsertString = @"insert into Categories(CompanyName, Description)
                    values('Tech', 'An IT Company')";
                String InsertString1 = @"insert into Categories(CompanyName, Description)
                    values('Sony', 'An Electronics Company')";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(InsertString, sqlConnection);
                SqlCommand sqlCommand1 = new SqlCommand(InsertString1, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlCommand1.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Data Inserted");
                try
                {
                    sqlConnection.Close();
                }
                catch(SqlException sq)
                {
                    Console.WriteLine(sq.ToString());
                }
            }
        }
    }
}
