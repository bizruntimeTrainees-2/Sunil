using System;

namespace AssemblyOne
{
    public class AssemblyOneClassOne
    {
        //internal int id = 101;
        protected internal int id = 101;
    }
    public class AssemblyOneClassTwo
    {
        public void SampleMethod()
        {
            AssemblyOneClassOne a1 = new AssemblyOneClassOne();
            Console.WriteLine(a1.id);
        }
    }
}
