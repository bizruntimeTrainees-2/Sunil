using System;

namespace ConsoleApp7
{
    class Program
    {
        public int id;
        public String name;
        public int age;
        Program(int i, String str, int j)
        {
            this.id = i;
            this.name = str;
            this.age = j;
        }
        void display()
        {
            Console.WriteLine(id + " " + name + " " + age);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program(1, "Sunil", 22);
            Program p2 = new Program(2, "naveen", 21);
            p1.display();
            p2.display();

        }
    }
}
