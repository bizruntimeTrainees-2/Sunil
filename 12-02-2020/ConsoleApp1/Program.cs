using System;
using System.IO;


namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            //string con = "Data Source=.; database=master; integrated security= SSPI";
            //SqlConnection sqlConnection = new SqlConnection(con);
            //SqlDataReader rdr = null;
            //try
            //{
            //    SqlCommand sqlCommand = new SqlCommand("select * from sales_customers2", sqlConnection);
            //    sqlConnection.Open();
            //    rdr = sqlCommand.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        Console.WriteLine(rdr[0]);
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //finally
            //{
            //    sqlConnection.Close();
            //}
            SqlCommandObject.commandObject();
            Console.WriteLine("-------------------");
            InsertData.insertData();
            Console.WriteLine("-------------------");
            SqlCommandObject.commandObject();
            Console.WriteLine("-------------------");
            Update.update();
            Console.WriteLine("-------------------");
            SqlCommandObject.commandObject();
            Console.WriteLine("-------------------");
            Delete.delete();
            Console.WriteLine("-------------------");
            SqlCommandObject.commandObject();
            Console.WriteLine("-------------------");
        }
    }
}
