using System;
using System.Collections.Generic;
using System.Text;

namespace SerilalizationAndDeserliazationAssignment
{
    public class Account
    {
        public int AccountNo { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Amount Deposited: {amount}");
        }

        public void WithDraw(double amount)
        {
            if (Balance - amount >= 500)
            {
                Balance = Balance - amount;
                Console.WriteLine($"Amount Withdrawn: {amount}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds! Minimum balance of Rs.500 must be maintained.");
            }
        }

        public double CheckBalance()
        {
            return Balance;
        }
    }

}
