using System;
using System.IO;

namespace ConsoleApp1
{
    class FileInfoExample1
    {
        public void creatingFile()
        {
            String path = @"G:\MyTestFile1.txt";
            FileInfo fi = new FileInfo(path);
            File.Create(path);
            Console.WriteLine("File has been Created");
        }
    }
}
