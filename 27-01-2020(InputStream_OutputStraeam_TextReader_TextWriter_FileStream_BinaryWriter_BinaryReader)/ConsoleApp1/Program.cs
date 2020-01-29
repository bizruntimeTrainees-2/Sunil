using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //static void Main(string[] args)
        static async Task Main(string[] args)
        {
            /*WriteToFile obj = new WriteToFile();
            obj.data();
            Console.ReadKey();*/

            /* DataReading obj = new DataReading();
             obj.readingData();*/

            /* WritingAndReadingFromCDrive obj = new WritingAndReadingFromCDrive();
             obj.ReadWriteMethod();*/

            ReadAndDisplayFilesAsync obj = new ReadAndDisplayFilesAsync();
            await obj.readAndDisplayFilesAsync();
        }
    }
}
