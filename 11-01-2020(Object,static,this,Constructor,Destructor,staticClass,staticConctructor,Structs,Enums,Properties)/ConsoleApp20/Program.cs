using System;

namespace ConsoleApp20
{
    public class Employee
    {
        private String name;
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "sunil";
            Console.WriteLine("Employee Name: " + e1.Name);
        }
    }
}
