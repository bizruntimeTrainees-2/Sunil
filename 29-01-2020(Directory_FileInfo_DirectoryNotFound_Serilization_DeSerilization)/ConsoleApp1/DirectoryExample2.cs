using System;
using System.IO;

namespace ConsoleApp1
{
    class DirectoryExample2
    {
        public void CreatingDirectory()
        {
            String dir = @"F:\NewDirectory";
            try
            {
                DirectoryInfo directory = new DirectoryInfo(dir);

                // check whether the directory is exist are not

                if (directory.Exists == false)
                {
                    Directory.CreateDirectory(dir);
                }
                Console.WriteLine("Directory successfully created");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
