using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class MethodSyntaxExample2 
    {
        public void MethodSyntaxExample()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentId = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentId = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 15 }
            };

            var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20);

            foreach(Student std in teenAgerStudents)
            {
                Console.WriteLine(std.StudentName);
            }
        }
    }
}
