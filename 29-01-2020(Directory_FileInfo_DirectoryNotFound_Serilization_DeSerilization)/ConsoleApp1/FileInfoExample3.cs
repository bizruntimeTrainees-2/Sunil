using System;
using System.IO;

namespace ConsoleApp1
{
    class FileInfoExample3
    {
        public void delete()
        {
            FileInfo fi = new FileInfo(@"G:\MyTestFilecreatetext1.txt");
            fi.Delete();
            Console.WriteLine("File Deleted Successfully");
        }
    }
}
