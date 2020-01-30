using System;
using System.IO;

namespace ConsoleApp2
{
    class StringReaderExample
    {
        public void stringReader()
        {
            StringWriter sw = new StringWriter();
            sw.WriteLine("Hello, This message was3 read by Stringreader");
            sw.Close();

            //creating instance to StringReader
            StringReader sr = new StringReader(sw.ToString());
            //Reading Data
            while(sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
