using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public delegate void Transformer(int x);
    class EventsDemo
    {
        static int i;
        public void Method()
        {
            Console.WriteLine("Please enter any Number");
            try
            {
                i = int.Parse(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message +  ": Enter Only Numeric Values and Try Again");
                return;
            }
            Transformer t;
            t = square;
            t += cube;
            t.Invoke(i);

            NotificationMethods obj = new NotificationMethods();

            obj.TransformerEvents += User1.Xhandler;
            obj.TransformerEvents += User2.Yhandler;

            obj.NotifyOneCell(i);
        }
        public static void square(int x)
        {
            Console.WriteLine(x * x);
        }
        public static void cube(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }
}
