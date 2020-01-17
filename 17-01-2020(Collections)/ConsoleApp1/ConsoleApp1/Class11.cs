using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1
{
    class StudentSort :IComparable<StudentSort>
    {
        public int Sid { get; set; }
        public String Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo( StudentSort other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }
        public int Compare(StudentSort x, StudentSort y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
    class CompareStudents : IComparer<StudentSort>
    {
        public int Compare(StudentSort x, StudentSort y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
}
