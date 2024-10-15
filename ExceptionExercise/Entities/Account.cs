using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExercise.Entities
{
    internal class Account
    {
        public int Number {  get; set; }
        public string Holder {  get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void deposit(double value)
        {
            Balance += value;
        }

        public void withdraw(double value)
        {

            if(value > Balance)
            {
                throw new WithdrawException("Withdraw Error: Not enough balance.");

            }
            if(value > WithdrawLimit)
            {
                throw new WithdrawException("Withdraw error: Withdraw above limit.");
            }
            
            Balance -= value;
        }
    }
}
