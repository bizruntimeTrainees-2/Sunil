using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    delegate bool IsYoungerThan(Student std, int youngerAge);
    class Example5
    {
        public void Method5()
        {
            IsYoungerThan isYoungerThan = (s, youngerAge) =>
            {
                Console.WriteLine("Lambda Expressin With Multiple Expressions");
                return s.Age < youngerAge;
            };
            Student std = new Student() { Age = 25 };
            Console.WriteLine(isYoungerThan(std, 26));
        }
    }
}
