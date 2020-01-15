using System;

namespace ConsoleApp1
{
    //public delegate int NumberChanger(int n,int p);
    // public delegate void SampleDelegate();
    public delegate int SampleDelegate();
    class Program : /*TestDelegate*/ /*MultiCastDelegates*/ Class3
    {
        static void Main(string[] args)
        {
            /*//create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            Console.WriteLine("Value of Num: {0}", nc1(5, 25));
            Console.WriteLine("Value of Num: {0}", nc2(25, 5));
            Console.ReadKey();*/
            /*SampleDelegate del1, del2, del3, del4, del5;
            del1 = new SampleDelegate(SampleMethod1);
            del2 = new SampleDelegate(SampleMethod2);
            del3 = new SampleDelegate(SampleMethod3);
            del4 = new SampleDelegate(SampleMethod4);*/
            /*del5 = del1 + del2 + de13 + del4;
            del5();
            del5 = del1 - del2 + de13 - del4;
            del5();*/

            /* SampleDelegate del = new SampleDelegate(SampleMethod1);
            del += SampleMethod2;
            del += SampleMethod3;
            del();*/
            /*del5 = del4 + del2 + del3 + del1;
            del5();*/

            SampleDelegate del = new SampleDelegate(SampleMethod1);
            del += SampleMethod2;

            int num = del();
            Console.WriteLine(num);
        }
    }
}
