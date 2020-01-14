using System;

namespace ConsoleApp21
{
    public class Employee
    {
        private static int objectCount;

        public  Employee()
        {
            objectCount++;
        }
        public static int ObjectCount
        {
            get
            {
                return objectCount;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            Console.WriteLine("No.Of Employees: " + Employee.ObjectCount);
        }
    }
}
