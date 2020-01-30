using System;
using System.IO;

namespace ConsoleApp1
{
    class DirectoryExample3
    {
        public void creatingSubDirectory()
        {
            String path = @"F:\NewDirectory";
            DirectoryInfo directory = new DirectoryInfo(path);
            try
            {                           
                directory.CreateSubdirectory("SubDir");
                directory.CreateSubdirectory("new");
                Console.WriteLine("SubDirectory Created Successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                directory.Delete(true);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
