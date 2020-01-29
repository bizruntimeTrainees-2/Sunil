using System;
using System.IO;

namespace TextWriterReader
{
    class TextReaderEx2
    {
        public void textReader()
        {
            StreamReader sr = File.OpenText("G:\\C#\\27-01-2020\\files_generated\\file2.txt");
            String str = sr.ReadLine();

            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
