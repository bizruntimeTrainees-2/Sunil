using System;

namespace ConsoleApp3
{
    class Program
    {
        public int id;
        public String str;
        public void insert(int i, String s)
        {
            this.id = i;
            this.str = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + str);

        }
        static void Main(string[] args)
        {
            int id = 1;
            String str = "Sunil";
            Program p = new Program();
            p.insert(id, str);
            p.display();
        }
    }
}
