using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Example6
    {
        delegate bool IsAdult(Student std);
        public void Method6()
        {
            IsAdult isAdult = (s) =>
            {
                int adultAge = 18;
                return s.Age >= adultAge;
            };
            Student std = new Student() { Age = 25 };
            Console.WriteLine(isAdult(std));
        }
    }
}
