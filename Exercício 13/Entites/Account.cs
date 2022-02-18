using System;

namespace Exercício_13.Entites
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }

        public Account(int number, string holder, double balance) : this(number, holder)
        {
            Balance = balance;
        }
        public virtual void Whthdraw(double amount)
        {
            Balance -= amount + 5;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
