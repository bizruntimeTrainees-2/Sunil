using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BufferedStreamExample1 obj = new BufferedStreamExample1();
            obj.bufferedStream();*/

            MemoryStreamExampleWithoutBuffer obj = new MemoryStreamExampleWithoutBuffer();
            obj.memoryStream();
        }
    }
}
