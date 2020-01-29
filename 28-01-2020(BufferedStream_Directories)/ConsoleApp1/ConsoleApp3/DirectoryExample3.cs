using System;
using System.IO;

namespace ConsoleApp3
{
    class DirectoryExample3
    {
        public void movingDirectory()
        {
            String scourceDirectory = @"F:\moved";
            String DestinationDirectory = @"F:\DestDir";
            try
            {
                Directory.Move(scourceDirectory, DestinationDirectory);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
