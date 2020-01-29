using System;
using System.IO;

namespace TextWriterReader
{
    class TextWriterEx1
    {
        public void textWriter()
        {
            StreamWriter sw = File.CreateText("G:\\C#\\27-01-2020\\files_generated\\file4.txt");
            sw.WriteLine("First line of example");
            sw.WriteLine("And Second line");
            Console.WriteLine("Writing into file successfully");
        }
    }
}
