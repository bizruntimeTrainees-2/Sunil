using System;
using System.IO;

namespace ConsoleApp1
{
    class FileInfoExample2
    {
        public void createText()
        {
            String path = @"G:\MyTestFilecreatetext1.txt";
            FileInfo fi = new FileInfo(path);
            StreamWriter str = fi.CreateText();
            str.Write("Hello World!");
            Console.WriteLine("File has been created with text");
            str.Close();
        }
    }
}
