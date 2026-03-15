using _11_march_assignments;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_march_assignments
{

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool IsBestseller { get; set; }

        public double CalculateDiscountedPrice()
        {
            double currentPrice = Price;

            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Original Price: {Price:C}");

            // Condition 1: Bestseller Discount
            if (IsBestseller)
            {
                Console.WriteLine($"'{Title}' is a bestseller. Applying 10% discount.");
                currentPrice -= currentPrice * 0.10;
            }

            // Condition 2: High Price Discount
            if (Price > 500)
            {
                Console.WriteLine($"'{Title}' is priced over 500. Applying additional 5% discount.");
                currentPrice -= currentPrice * 0.05;
            }

            return currentPrice;
        }

        public void ProcessBooks()
        {
            Book book1 = new Book
            {
                Title = "The Power of Habit",
                Author = "Charles Duhigg",
                Price = 600,
                IsBestseller = true
            };

            Book book2 = new Book
            {
                Title = "C# Programming",
                Author = "Jane Doe",
                Price = 450,
                IsBestseller = false
            };

            double final1 = book1.CalculateDiscountedPrice();
            Console.WriteLine("Final Price: " + final1);
            Console.WriteLine();

            double final2 = book2.CalculateDiscountedPrice();
            Console.WriteLine("Final Price: " + final2);
        }
  

    }
}
