using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* LinqDemoProgram ldq = new LinqDemoProgram();
             ldq.DemoProgram();*/

            /*StudentDetails std = new StudentDetails();
            std.studentDetails();*/

            LinqExample le = new LinqExample();
            le.Method();
            Console.WriteLine("End Of The Program!");
        }
    }
}
