using System;
using System.IO;
using System.Linq;

namespace ConsoleApp3
{
    class DirectoryExample2
    {
        public void retrivingDataPresentInTheFile()
        {
            string TargetDirectory = @"F:\moved";

            var files = from retrievedFile in Directory.EnumerateFiles(TargetDirectory, "*.txt", SearchOption.AllDirectories)
            from line in File.ReadLines(retrievedFile)
            where line.Contains("Example")
            select new
            {
                File = retrievedFile,
                line = line
            };
            foreach(var f in files)
            {
                Console.WriteLine($"{f.File} contains {f.line}");
            }
            Console.WriteLine($"{files.Count().ToString()} lines found");
        }
    }
}
