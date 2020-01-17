using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  GenericList gl = new GenericList();
                  gl.genericList();*/

            /*Generics1 g = new Generics1();
            bool result = g.Compare(10, 20);*/

            /*Generics2 g = new Generics2();
            bool result = g.Compare(10, 10);*/

            /* Generics3 g = new Generics3();
             bool result = g.Compare<int>(10, 10);
             Console.WriteLine(result);
             Generics3 g1 = new Generics3();
             bool result1 = g1.Compare<double>(10.5, 5.10);*/

            /*Generic4 g = new Generic4();
            g.Add<int>(10, 20);
            g.sub<int>(10, 10);
            g.mult<int>(10, 20);
            g.div<int>(20, 2);*/

            /* Generics5<int> g = new Generics5<int>();
             g.Add(10, 20);
             g.sub(10, 10);
             g.mult(10, 20);
             g.div(20, 2);*/

            /* DictionaryCollection dc = new DictionaryCollection();
             dc.dictionaryCollectionMethod();*/

            /*  List<Customer> Customers = new List<Customer>();
              Customer c1 = new Customer() {Cusid = 101, Name= "soot", City="abg", Bal= 25000 };
              Customer c2 = new Customer() { Cusid = 121, Name = "voot", City = "kjut", Bal = 2000 };
              Customer c3 = new Customer() { Cusid = 161, Name = "pot", City = "jkla", Bal = 5000 };
              Customer c4 = new Customer() { Cusid = 105, Name = "sot", City = "ghr", Bal = 2500 };

              Customers.Add(c1);
              Customers.Add(c2);
              Customers.Add(c3);
              Customers.Add(c4);

              foreach(Customer obj in Customers)
              {
                  Console.WriteLine(obj.Cusid + " " + obj.Name + " " + obj.City + " " + obj.Bal);
              }*/

            /*Student s1 = new Student() { Sid = 109, Name= "asdfr", Class= 8, Marks= 50.6f};
            Student s2 = new Student() { Sid = 101, Name = "jlled", Class = 8, Marks = 40.6f };
            Student s3 = new Student() { Sid = 106, Name = "lajdh", Class = 8, Marks = 35.6f };
            Student s4 = new Student() { Sid = 105, Name = "hjrtr", Class = 8, Marks = 60.6f };

            List<Student> students = new List<Student>() { s1, s2, s3, s4 };

            students.Sort();

            foreach(Student s in students)
            {
                Console.WriteLine(s.Sid + " " + s.Name + " " + s.Class + s.Marks);
            }*/

            /* Sorting s1 = new Sorting() { Sid = 109, Name = "asdfr", Class = 8, Marks = 50.6f };
             Sorting s2 = new Sorting() { Sid = 101, Name = "jlled", Class = 8, Marks = 40.6f };
             Sorting s3 = new Sorting() { Sid = 106, Name = "lajdh", Class = 8, Marks = 35.6f };
             Sorting s4 = new Sorting() { Sid = 105, Name = "hjrtr", Class = 8, Marks = 60.6f };

             List<Sorting> Sortings = new List<Sorting>() { s1, s2, s3, s4 };

             Sortings.Sort();
             Sortings.Reverse();

             foreach (Sorting s in Sortings)
             {
                 Console.WriteLine(s.Sid + " " + s.Name + " " + s.Class + s.Marks);
             }*/

            /*StudentSort s1 = new StudentSort() { Sid = 109, Name = "asdfr", Class = 8, Marks = 50.6f };
            StudentSort s2 = new StudentSort() { Sid = 101, Name = "jlled", Class = 8, Marks = 40.6f };
            StudentSort s3 = new StudentSort() { Sid = 106, Name = "lajdh", Class = 8, Marks = 35.6f };
            StudentSort s4 = new StudentSort() { Sid = 105, Name = "hjrtr", Class = 8, Marks = 60.6f };

            List<StudentSort> Sortings = new List<StudentSort>() { s1, s2, s3, s4 };*/
            // CompareStudents obj = new CompareStudents();
            //Sortings.Sort(); it executes compareTo()
            //Sortings.Sort(obj);// It executes compare()

            // Sortings.Sort(1, 3, obj);


            //Comparison<StudentSort> obj = new Comparison<StudentSort>(CompareNames);
            //Sortings.Sort(obj);
            //Sortings.Sort(CompareNames);

            // Sortings.Sort(delegate (StudentSort s1, StudentSort s2) { return s1.Name.CompareTo(s2.Name); });

            /* Sortings.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
             foreach (StudentSort s in Sortings)
             {
                 Console.WriteLine(s.Sid + " " + s.Name + " " + s.Class + s.Marks);
             }
             Console.WriteLine("End of program");*/

            List<EmployeeClass> Employees = new List<EmployeeClass>();
            Employees.Add(new EmployeeClass { Id = 101, Name = "suri", Job = "MGR", salary = 75000 });
            Employees.Add(new EmployeeClass { Id = 102, Name = "juri", Job = "TL", salary = 45000 });
            Employees.Add(new EmployeeClass { Id = 103, Name = "vuri", Job = "PH", salary = 55000 });
            Employees.Add(new EmployeeClass { Id = 104, Name = "nuri", Job = "DEV", salary = 250000 });
            Employees.Add(new EmployeeClass { Id = 105, Name = "puri", Job = "TEST", salary = 250 });
            Employees.Add(new EmployeeClass { Id = 106, Name = "kuri", Job = "HR", salary = 2500 });

            foreach (EmployeeClass emp in Employees)
            {
                Console.WriteLine(emp.Id + " " + emp.Name + " " + emp .Job + " " + emp.salary);
            }
            Console.WriteLine("End of program");
        }
        /*private static int CompareNames(StudentSort x, StudentSort y)
        {
            return x.Name.CompareTo(y.Name);
        }*/
    }
}

