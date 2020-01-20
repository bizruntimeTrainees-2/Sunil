using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Example7
    {
        public void method7()
        {
            Func<Student, bool> IsStudentTeenAger = s => s.Age > 12 && s.Age < 20;
            Student stud = new Student() { Age = 21};
           Console.WriteLine(IsStudentTeenAger(stud));
        }
    }
}
