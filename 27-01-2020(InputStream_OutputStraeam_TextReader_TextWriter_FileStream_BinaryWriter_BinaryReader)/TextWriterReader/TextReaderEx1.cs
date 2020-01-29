using System;
using System.IO;

namespace TextWriterReader
{
    class TextReaderEx1
    {
        public void textReader()
        {
            using (StreamReader sr = File.OpenText("G:\\C#\\27-01-2020\\files_generated\\file2.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
