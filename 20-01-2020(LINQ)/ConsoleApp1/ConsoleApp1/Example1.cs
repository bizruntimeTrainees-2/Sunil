using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Example1
    {
        delegate bool IsTeenAger(Student std);
        public void method1()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentId = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentId = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 15 }
            };
            IsTeenAger isTeenAger = delegate (Student s) { return s.Age > 12 && s.Age < 20; };

            Student stud = new Student() { Age = 25 };

            Console.WriteLine(isTeenAger(stud));
        }
    }
}
