using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class StringWriterexample1
    {
        public void stringWriter()
        {
            String text = "Hello, Welcome to my program\n " + "It is an example for stringWriter\n "
                + "For every statment i had given comment lines ";

            //Creating an instance to the string builder
            StringBuilder sb = new StringBuilder();

            // Passing StringBuilder instance to the StreamWriter
            StringWriter sw = new StringWriter(sb);

            //write data using stringWriter
            sw.Write(text);
            sw.Flush();

            //Closing Writer connection
            sw.Close();

            //Creating srtingReader instance by  passing stringBuilder
            StringReader sr = new StringReader(sb.ToString());

            //Reading Data
            while(sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
