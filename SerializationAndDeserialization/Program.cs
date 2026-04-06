using System.Text.Json;

namespace SerilalizationAndDeserliazationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account;
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "account.json");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                account = JsonSerializer.Deserialize<Account>(json);
                Console.WriteLine("Welcome Back!!!");
                Console.WriteLine($"Available Balance: {account.CheckBalance()}");
            }
            else
            {
                account = new Account();
                Console.WriteLine("Welcome! Enter Account Details:");
                Console.Write("Account Number: ");
                account.AccountNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Account Name: ");
                account.AccountHolderName = Console.ReadLine();
                Console.Write("BankName: ");
                account.BankName = Console.ReadLine();
                Console.Write("Opening Balance: ");
                account.Balance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Acc created successfully!");

                string jsonNew = JsonSerializer.Serialize(account);
                File.WriteAllText(filePath, jsonNew);
            }


            while (true)
            {
                Console.WriteLine("\nWhat do you wish to do?");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Display Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Amount To Deposit: ");
                        double amount1 = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(amount1);
                        break;
                    case 2:
                        Console.Write("Enter Amount To WithDraw: ");
                        double amount2 = Convert.ToDouble(Console.ReadLine());
                        account.WithDraw(amount2);
                        break;
                    case 3:
                        Console.WriteLine($"Available Balance: {account.CheckBalance()}");
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Enter Valid Choice");
                        break;
                }
                string json = JsonSerializer.Serialize(account);
                File.WriteAllText(filePath, json);
                Console.WriteLine("File saved at: " + filePath);
            }
        }
    }
}
