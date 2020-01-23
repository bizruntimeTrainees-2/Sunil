using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadLocking
{
    class Account1
    {
        int _id; double _balance;
        public Account1(int id, double balance)
        {
            this._id = id;
            this._balance = balance;
        }
        public int ID
        {
            get { return _id;  }
        }
        public void Withdraw(double amount)
        {
            _balance -= amount;
        }
        public void Deposite(double amount)
        {
            _balance += amount;
        }
    }
}
