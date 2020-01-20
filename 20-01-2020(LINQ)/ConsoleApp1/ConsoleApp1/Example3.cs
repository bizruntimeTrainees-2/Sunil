using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Example3
    {
        delegate bool IsYoungerthan(Student std, int younger);
        public void method3()
        {
            IsYoungerthan isYoungerthan = (s, youngerAge) => s.Age < youngerAge;
            Student sd = new Student() { Age = 25 };
            Console.WriteLine( isYoungerthan(sd, 26));
        }
    }
}
