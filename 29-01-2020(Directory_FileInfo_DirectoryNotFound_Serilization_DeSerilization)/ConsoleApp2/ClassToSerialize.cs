using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    [Serializable]
    class ClassToSerialize
    {
        private int _age;
        private String _name;
        private String _CompanyName;

        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }
        public string CompanyName { get => _CompanyName; set => _CompanyName = value; }
    }
}
