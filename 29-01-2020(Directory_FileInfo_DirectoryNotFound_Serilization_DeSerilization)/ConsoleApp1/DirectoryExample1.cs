using System;
using System.IO;

namespace ConsoleApp1
{
    class DirectoryExample1
    {
        public void gettingDirectoryInfo(DirectoryInfo source, DirectoryInfo target)
        {
            // if two directories names are same then return the program
            if(source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }
            //Check if the directory exist, if not create it
            if(Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
               Console.WriteLine( Directory.GetCreationTime(target.FullName));
            }
            String dir = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            Console.WriteLine(dir);
            // copy each file into its new directory
            foreach (FileInfo fi in source.GetFiles())
            {                         
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);                
            }
            // Copy each subdirectory using recursion.           
            foreach(DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                gettingDirectoryInfo(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}
