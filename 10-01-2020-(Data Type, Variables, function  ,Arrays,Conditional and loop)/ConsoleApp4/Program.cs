using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            int val1 = 10, val2 = 20;
            Console.WriteLine("Before passing value \n val1 = " + val1 + "\n val2 = " + val2);
            p1.OutPara(out val1, out val2);
            Console.WriteLine("After passing value \n val1 = " + val1 +  "\n val2 = " + val2);
        }
        public void OutPara(out int a, out int b)
        {
            int val = 5;
            a = val;
            b = val;
            a *= a;
            b *= b;
        }
    }
}
