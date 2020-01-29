using System;
using System.IO;

namespace ConsoleApp3
{
    class DirectoryExample5
    {
        public void SearchDirectoryWithSpecifiedChar()
        {
            try
            {
                String[] dirs = Directory.GetDirectories(@"C:\", "p*", SearchOption.TopDirectoryOnly);
                Console.WriteLine($"Thenumber of directories with starting letter p are {dirs.Length}");

                foreach (var dir in dirs)
                {
                    Console.WriteLine(dir);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }            
        }
    }
}
