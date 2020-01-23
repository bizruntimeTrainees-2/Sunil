using System;
using System.Threading;

namespace ThreadLocking
{
    class AccountManager1
    {
        Account1 _fromAccount; Account1 _toAccount; double _amountToTransfer;

        public AccountManager1(Account1 fromAccount, Account1 toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }
        public void Transfer()
        {
            Object _lock1, _lock2;
            if(_fromAccount.ID < _toAccount.ID)
            {
                _lock1 = _fromAccount; _lock2 = _toAccount;
            }
            else
            {
                _lock1 = _toAccount;
                _lock2 = _fromAccount;
            }
            Console.WriteLine(Thread.CurrentThread.Name + " Trying to acquire lock on " + ((Account1)_lock1).ID.ToString());
            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " + ((Account1)_lock2).ID.ToString());
                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " acquire lock on " + ((Account1)_lock2).ID.ToString());
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposite(_amountToTransfer);
                    Console.WriteLine(Thread.CurrentThread.Name + " Transfered " + _amountToTransfer.ToString() + " from " + _fromAccount.ID.ToString());
                }
            }
        }
    }
}
