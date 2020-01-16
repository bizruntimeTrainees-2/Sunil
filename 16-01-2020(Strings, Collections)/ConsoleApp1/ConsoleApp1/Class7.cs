using System;

namespace ConsoleApp1
{
    class S7
    {
        public void test()
        {
            int i = 0;
            String s = "108";
            bool result = int.TryParse(s, out i);
            Console.WriteLine(result);
        }
    }
}
