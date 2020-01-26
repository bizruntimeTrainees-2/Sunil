using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class AsyncExample1
    {
        public void Method()
        {
            Console.WriteLine($"Main Thread Started");
            Task<Employee> task1 = Task<Employee>.Factory.StartNew(() =>
            {
                Employee emp = new Employee()
                {
                    ID = 101,
                    Name = "Ranga",
                    Salary = 25000
                };
                return emp;
            });
            Employee emp = task1.Result;
            Console.WriteLine($"{emp.ID}, Name : {emp.Name}, Salary : {emp.Salary}");
            Console.WriteLine($"Main Thread End");
            Console.ReadKey();
        }
    }
}
