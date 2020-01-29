using System;
using System.IO;
using System.Diagnostics;

namespace ConsoleApp1
{
    class MemoryStreamExampleWithoutBuffer
    {
        public void memoryStream()
        {
            var t = Stopwatch.StartNew();
            using(MemoryStream memory = new MemoryStream())
            {
                for(int i = 0; i <= 5000000; i++)
                {
                    memory.WriteByte(5);
                }
            }
            t.Stop();
            Console.WriteLine("Total Time Elapsed: " + t.Elapsed.TotalMilliseconds);
        }
    }
}
