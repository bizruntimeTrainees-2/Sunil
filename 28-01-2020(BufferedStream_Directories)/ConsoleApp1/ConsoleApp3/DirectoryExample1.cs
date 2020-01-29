using System;
using System.IO;

namespace ConsoleApp3
{
    class DirectoryExample1
    {
        public void movingOneDirectoryFilesToAnother()
        {
            string sourceDirectory = @"F:\sd";
            string TargetDirectory = @"F:\moved";

            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt");

                foreach(string currentFile in txtFiles)
                {
                    String fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    Directory.Move(currentFile, Path.Combine(TargetDirectory, fileName));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
