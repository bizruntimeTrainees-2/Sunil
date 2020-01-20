using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Example8
    {
        public void method8()
        {
            Action<Student> printStudentDetails = s => Console.WriteLine("Name : {0}, Age: {1}", s.StudentName, s.Age);
            Student std = new Student() { StudentName = "Bill", Age = 21 };
            printStudentDetails(std);
        }
    }
}
