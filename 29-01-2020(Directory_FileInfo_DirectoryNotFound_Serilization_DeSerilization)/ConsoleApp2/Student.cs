using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    [Serializable]
    class Student
    {
        int _rollNo;
        String _name;
        public Student(int rollNo, string Name)
        {
            this._rollNo = rollNo;
            this._name = Name;
        }

    }
}
