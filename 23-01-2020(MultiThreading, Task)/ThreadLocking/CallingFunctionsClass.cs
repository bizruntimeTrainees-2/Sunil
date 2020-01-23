using System;
using System.Threading;

namespace ThreadLocking
{
    class CallingFunctionsClass
    {
        public void methodContainingCallingFunctions()
        {
            Console.WriteLine("Main Started");
            Account accountA = new Account(101, 5000);
            Account accountB = new Account(102, 5000);

            AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);
            Thread t1 = new Thread(accountManagerA.Transfer);
            t1.Name = "t1";
            AccountManager accountManagerB = new AccountManager(accountB, accountA, 2000);
            Thread t2 = new Thread(accountManagerB.Transfer);
            t2.Name = "t2";

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine("Main Colpleted");
        }
    }
}
