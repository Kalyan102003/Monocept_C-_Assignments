using System;
using System.Collections.Generic;
using System.Text;

namespace _11_march_assignments
{
        public class BankAccount
        {
            public string AccountHolder;
            public double Balance;
            public BankAccount(string name, double balance)
            {
                AccountHolder = name;
                Balance = balance;
            }

            public void Deposit(double amount)
            {
                Balance += amount;
            }

            public void Withdraw(double amount)
            {
                if (amount <= Balance)
                    Balance -= amount;
                else
                    Console.WriteLine("Insufficient Balance");
            }

            public void StartGame()
            {
                Random r = new Random();

                BankAccount acc1 = new BankAccount("Account1", r.Next(2000, 5000));
                BankAccount acc2 = new BankAccount("Account2", r.Next(2000, 5000));

                Console.WriteLine("Account1 Balance: " + acc1.Balance);
                Console.WriteLine("Account2 Balance: " + acc2.Balance);

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("\nRound " + i);

                    Console.Write("Account1 Withdraw or Deposit (w/d): ");
                    char c1 = Convert.ToChar(Console.ReadLine());

                    Console.Write("Enter Amount: ");
                    double amt1 = Convert.ToDouble(Console.ReadLine());

                    if (c1 == 'w')
                        acc1.Withdraw(amt1);
                    else
                        acc1.Deposit(amt1);

                    Console.Write("Account2 Withdraw or Deposit (w/d): ");
                    char c2 = Convert.ToChar(Console.ReadLine());

                    Console.Write("Enter Amount: ");
                    double amt2 = Convert.ToDouble(Console.ReadLine());

                    if (c2 == 'w')
                        acc2.Withdraw(amt2);
                    else
                        acc2.Deposit(amt2);
                }

                Console.WriteLine("\nFinal Balance");
                Console.WriteLine("Account1: " + acc1.Balance);
                Console.WriteLine("Account2: " + acc2.Balance);

                if (acc1.Balance > acc2.Balance)
                    Console.WriteLine("Account1 Wins");
                else
                    Console.WriteLine("Account2 Wins");
            }
        }
 }
