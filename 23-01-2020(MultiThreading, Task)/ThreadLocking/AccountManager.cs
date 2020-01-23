using System;
using System.Threading;

namespace ThreadLocking
{
    class AccountManager
    {
        Account _fromAccount; Account _toAccount; double _amountToTransfer;
        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }
        public void Transfer()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + _fromAccount.Id.ToString());
            lock (_fromAccount)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " acquire lock on " + _fromAccount.Id.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + " Suspended for 1 second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " back in action and Trying to acquire lock on " + _toAccount.Id.ToString());
                lock (_toAccount)
                {
                    Console.WriteLine("This code will not be executed");
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }
            }
        }
    }
}
