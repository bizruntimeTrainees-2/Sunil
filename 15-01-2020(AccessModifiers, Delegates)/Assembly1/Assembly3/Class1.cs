using System;
using AssemblyOne;

namespace Assembly3
{
    public class Assembly3 : AssemblyOneClassOne
    {
        public void Method()
        {
            Assembly3 a3 = new Assembly3();
            Console.WriteLine(a3.id);
        }
    }
}
