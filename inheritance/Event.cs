using System;

namespace _13_march_Tasks_inheritance
{
    public class Event : Banquet
    {
        public int TotalEarning;
        public int TollPax { get; set; }

       
        public class PaxException : Exception
        {
            public PaxException(string message) : base(message)
            {
            }
        }

        public Event(int banquetId, string banquetName, int capacity, int tollPax)
            : base(banquetId, banquetName, capacity)
        {
            TollPax = tollPax;
        }

        public override int CalculateEarning()
        {
            int earning = base.CalculateEarning();

            try
            {
                if (TollPax > Capacity)
                {
                    throw new PaxException("Persons entered into the banquet is greater than capacity.");
                }
            }
            catch (PaxException e)
            {
                Console.WriteLine(e.Message);


                Console.WriteLine("Enter Total Pax again:");
                TollPax = int.Parse(Console.ReadLine());
            }

           
            TotalEarning = TollPax * earning;
            return TotalEarning;
        }

        public void DisplayEventDetails()
        {
            Console.WriteLine($"Banquet Id: {BanquetId}");
            Console.WriteLine($"Banquet Name: {BanquetName}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Total Pax: {TollPax}");
            Console.WriteLine($"Per Person Earning: {Earning}");
            Console.WriteLine($"Total Earning: {TotalEarning}");
        }
    }
}