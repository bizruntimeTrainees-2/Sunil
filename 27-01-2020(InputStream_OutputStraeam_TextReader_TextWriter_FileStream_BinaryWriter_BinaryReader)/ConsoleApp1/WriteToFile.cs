using System;
using System.IO;

namespace ConsoleApp1
{
    class WriteToFile
    {
        public void data()
        {
            // This creates a file named file1.txt at specified location
            StreamWriter sw = new StreamWriter("G:\\C#\\27-01-2020\\files_generated\\file1.txt");
            // To write on the console screen
            Console.WriteLine("Enteer text that you want to write on to the file");
            //To read input from the user
            String str = Console.ReadLine();
            //To write a line in buffer
            sw.WriteLine(str);
            //To write in outputStream
            sw.Flush();
            //To close the stream.
            sw.Close();
        }
    }
}
