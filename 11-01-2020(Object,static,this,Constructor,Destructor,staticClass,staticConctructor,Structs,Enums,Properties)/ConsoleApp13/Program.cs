using System;

namespace ConsoleApp13
{
    public class Account
    {
        public int id;
        public String name;
        public static float rateOfIntrest;
        public Account(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        static Account()
        {
            rateOfIntrest = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + rateOfIntrest);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account ed = new Account(1, "abcds");
            Account ed1 = new Account(2, "qwert");
            Account ed2 = new Account(3, "zxcvb");
            ed.display();
            ed1.display();
            ed2.display();
        }
    }
}
