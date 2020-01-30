using System;
using System.IO;

namespace ConsoleApp2
{
    class DirectoryNotFoundExample1
    {
        public void directoryNotFound()
        {
            try
            {
                // Specify directory name that doesnot exist for this program demo
                String src = @"C\//jdkbdsavc";
                //If the directory is trying toset the current directory 
                //if the driectory does not exist means it throws DirectoryNotFoundException
                Directory.SetCurrentDirectory(src);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found" + ex.Message); 
            }
        }
    }
}
