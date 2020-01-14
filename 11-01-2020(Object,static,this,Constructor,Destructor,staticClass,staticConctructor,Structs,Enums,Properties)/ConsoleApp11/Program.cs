using System;

namespace ConsoleApp11
{
    public class EmployeeDetails{
        public int id;
        public String employeeName;
        public double salary;
        public static float rateOfIntrest = 8.8f;
        public static int objectCount = 0;
        public EmployeeDetails(int id, String employeeName, double salary)
        {
            this.id = id;
            this.employeeName = employeeName;
            this.salary = salary;
            objectCount++;
        }
        public void display()
        {
            Console.WriteLine(id + " " + employeeName + " " + salary + " " + rateOfIntrest);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails ed = new EmployeeDetails(1, "abcds", 50000);
            EmployeeDetails ed1 = new EmployeeDetails(2, "qwert", 60000);
            EmployeeDetails ed2 = new EmployeeDetails(3, "zxcvb", 70000);
            ed.display();
            ed1.display();
            ed2.display();
            Console.WriteLine("Total No.Of Objects are " + EmployeeDetails.objectCount);
        }
    }
}
