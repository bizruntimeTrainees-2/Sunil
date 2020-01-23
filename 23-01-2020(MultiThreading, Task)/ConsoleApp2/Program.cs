using System;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApp2
{
    class ThreadPerfrmance
    {
        static void Main(string[] args)
        {
            ExecutableClass obj = new ExecutableClass();
            obj.executableMethods();
        }
    }
}
