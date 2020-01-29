using System;
using System.IO;

namespace TextWriterReader
{
    class TextWriter
    {
        public void textWriter()
        {
            using (StreamWriter writer = File.CreateText("G:\\C#\\27-01-2020\\files_generated\\file3.txt"))
            {
                writer.WriteLine("Hello C#");
                writer.WriteLine("C# File Handling by JavaTpoint");
            }
            Console.WriteLine("Data written successfully...");
        }
    }
}
