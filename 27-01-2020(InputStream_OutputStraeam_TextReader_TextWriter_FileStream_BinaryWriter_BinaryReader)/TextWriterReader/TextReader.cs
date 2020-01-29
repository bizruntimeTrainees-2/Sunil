using System;
using System.IO;

namespace TextWriterReader
{
    class TextReader
    {
        public void textReader()
        {
            StreamReader sr = File.OpenText("G:\\C#\\27-01-2020\\files_generated\\file2.txt");
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
