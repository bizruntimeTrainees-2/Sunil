using System;
using System.IO;

namespace ConsoleApp3
{
    class DirectoryExample
    {
        public void CreatingDirectory()
        {
            String path = @"F:\MyDir";
            try
            {
                //Check the directory is already exist
                if (Directory.Exists(path))
                {
                    Console.WriteLine("This path already exist");
                        return;
                }
                //To create directory
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine($"The Directory Created Successfully at {Directory.GetCreationTime(path)}");
                //To delete directory
                di.Delete();
                Console.WriteLine("The directory was deleted successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
