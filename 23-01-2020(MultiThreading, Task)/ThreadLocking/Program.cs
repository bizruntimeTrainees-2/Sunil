using System;


namespace ThreadLocking
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutableClass ec = new ExecutableClass();
            ec.ExecutableStatments();
            /* CallingFunctionsClass obj = new CallingFunctionsClass();
             obj.methodContainingCallingFunctions();*/

            /* CallingFunctionsClass1 obj = new CallingFunctionsClass1();
             obj.MethodContainsCallingFunctions();*/
        }
    }
}
