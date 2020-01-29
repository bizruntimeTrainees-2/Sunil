using System;
using System.IO;
using System.Collections.Generic;


namespace ConsoleApp3
{
    class DirectoryExample4
    {
        public void EnumerateDirectories()
        {
            try
            {
                String docsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                List<String> dirs = new List<string>(Directory.EnumerateDirectories(docsPath));

                foreach (var dir in dirs)
                {
                    Console.WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");
                }
                Console.WriteLine($"{dirs.Count} directories Found");
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
