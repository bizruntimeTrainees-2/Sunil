using System;
using System.IO;

namespace ConsoleApp1
{
    class DataReading
    {
        public void readingData()
        {
            // Taking a input Stream i.e fle1.txt
            StreamReader sr = new StreamReader("G:\\C#\\27-01-2020\\files_generated\\file1.txt");

            Console.WriteLine("Content of the file");
            //This is used to specify where to start reading input stream
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            //This is to readLine from input stream
            string str = sr.ReadLine();
            //This is to read whole file line by line
            while(str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();
            //This is to close the stream
            sr.Close();
        }
    }
}
