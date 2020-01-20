using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Example2
    {
        delegate bool IsTeenAger(Student std);
        public void method2()
        {
            IsTeenAger isTeenAger = s => s.Age > 10 && s.Age < 20;
            Student std = new Student() { Age = 25 };
            Console.WriteLine(isTeenAger(std));
        }
    }
}
