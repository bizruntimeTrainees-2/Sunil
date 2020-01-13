using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ID1 = 101;
            student.NAME1 = "raju";
            student.EMAIL1 = "abc@gmail.com";
            Console.WriteLine("ID = " + student.ID1);
            Console.WriteLine("Name = " + student.NAME1);
            Console.WriteLine("Email = " + student.EMAIL1);
        }
    }
}
