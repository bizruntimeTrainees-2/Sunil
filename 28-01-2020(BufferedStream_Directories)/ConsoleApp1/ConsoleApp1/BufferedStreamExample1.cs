using System;
using System.IO;
using System.Diagnostics;

namespace ConsoleApp1
{
    class BufferedStreamExample1
    {
        public void bufferedStream()
        {
            var t = Stopwatch.StartNew();
            using (MemoryStream memory = new MemoryStream())
            using(BufferedStream bs = new BufferedStream(memory))
            {
                for(int i = 1; i <= 5000000; i++)
                {
                    bs.WriteByte(5);
                }
            }
            t.Stop();
            Console.WriteLine("BufferedStream Time: " + t.Elapsed.TotalMilliseconds);
        }
        
    }
}
