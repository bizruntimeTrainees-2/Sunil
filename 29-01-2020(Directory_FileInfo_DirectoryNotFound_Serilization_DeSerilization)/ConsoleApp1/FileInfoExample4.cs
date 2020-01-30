using System;
using System.IO;

namespace ConsoleApp1
{
    class FileInfoExample4
    {
        public void appendText()
        {
            FileInfo fi = new FileInfo(@"G:\MyTestFilecreatetext1.txt");
            StreamWriter sw = fi.AppendText();
            sw.Write(" This ");
            sw.Write("is ");
            sw.Write("Extra ");
            sw.Write("Text");
            Console.WriteLine("Text appended successfully");
            sw.Close();
        }
    }
}
