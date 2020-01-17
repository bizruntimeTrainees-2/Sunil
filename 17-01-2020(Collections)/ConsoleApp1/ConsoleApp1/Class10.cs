using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1
{
    class Sorting : IComparable<Sorting>
    {
        public int Sid { get; set; }
        public String Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Sorting other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }
    }
}
