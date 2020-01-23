using System;
using System.Threading;

namespace ThreadLocking
{
    class CallingFunctionsClass1
    {
        public void MethodContainsCallingFunctions()
        {
            Console.WriteLine("Main Started");
            Account1 account1A = new Account1(101, 5000);
            Account1 account1B = new Account1(102, 5000);

            AccountManager1 accountManager1A = new AccountManager1(account1A, account1B, 1000);
            Thread t1 = new Thread(accountManager1A.Transfer);
            t1.Name = "t1";

            AccountManager1 accountManager1B = new AccountManager1(account1B, account1A, 2000);
            Thread t2 = new Thread(accountManager1B.Transfer);
            t2.Name = "t2";

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine("Main Exit");
        }
    }
}
