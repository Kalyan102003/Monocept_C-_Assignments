using System;
using System.Collections.Generic;
using System.Text;

namespace _11_march_assignments
{
    
        public class Account
        {
            private string accountNumber;
            private string name;
            private double balance;
            private string accountType;

            Random r = new Random();

            // Constructor
            public Account(string name, double balance, string type)
            {
                this.name = name;
                this.balance = balance;
                this.accountType = type;
                accountNumber = "IDBI1000" + r.Next(100000, 999999);
            }

            public string GetAccountNumber()
            {
                return accountNumber;
            }

            public double GetBalance()
            {
                return balance;
            }

            public void Deposit(double amount)
            {
                balance += amount;
                Console.WriteLine("Amount Deposited Successfully");
            }

            public void Withdraw(double amount)
            {
                if (balance - amount < 500)
                    Console.WriteLine("Minimum balance must be 500");
                else
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawal Successful");
                }
            }

            public void Display()
            {
                Console.WriteLine("Account Number: " + accountNumber);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Balance: " + balance);
                Console.WriteLine("Type: " + accountType);
            }

            public void StartBank()
            {
                Account acc = null;

                while (true)
                {
                    Console.WriteLine("\n1. Create Account");
                    Console.WriteLine("2. View Balance");
                    Console.WriteLine("3. Deposit");
                    Console.WriteLine("4. Withdraw");
                    Console.WriteLine("5. Exit");

                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Name: ");
                            string n = Console.ReadLine();

                            Console.Write("Enter Initial Balance: ");
                            double b = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter Account Type (savings/current): ");
                            string t = Console.ReadLine();

                            acc = new Account(n, b, t);
                            acc.Display();
                            break;

                        case 2:
                            Console.WriteLine("Balance: " + acc.GetBalance());
                            break;

                        case 3:
                            Console.Write("Enter Amount: ");
                            double d = Convert.ToDouble(Console.ReadLine());
                            acc.Deposit(d);
                            break;

                        case 4:
                            Console.Write("Enter Amount: ");
                            double w = Convert.ToDouble(Console.ReadLine());
                            acc.Withdraw(w);
                            break;

                        case 5:
                            return;
                    }
                }
            }
        }
    }
