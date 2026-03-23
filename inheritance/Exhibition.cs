using System;
using System.Collections.Generic;
using System.Text;
using static _13_march_Tasks_inheritance.Event;

namespace _13_march_Tasks_inheritance
{
    public class Exhibition:Banquet

    {
        public int TotalStalls { get; set; }
        public int StallRent { get; set; }

        public int TotalEarning { get; set; }

        public class CapacityException : Exception
        {
            public CapacityException(string message) : base(message)
            {
            }
        }

        public Exhibition(int banquetId, string banquetName, int capacity,int totalstalls,int stallrent):base(banquetId, banquetName, capacity)
        {

            TotalStalls = totalstalls;
            StallRent = stallrent;
        }






        public override int CalculateEarning()
        {
            int earning = base.CalculateEarning();

            try
            {
                if (TotalStalls > (Capacity / 2))
                {
                    throw new Exception("Entered  the total stalls are is greater than capacity.",
                        new CapacityException("invalid"));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if(e.InnerException != null)
                {
                    Console.WriteLine(e.InnerException.Message);
                }
                
                Console.WriteLine("Enter Total stalls again:");
                TotalStalls = int.Parse(Console.ReadLine());
            }


            TotalEarning = TotalStalls * StallRent + earning;
            return TotalEarning;
        }


        public void DisplayDetails()
        {
            Console.WriteLine($"BanquetId: {BanquetId}");
            Console.WriteLine($"BanquetName: {BanquetName}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"TotalStalls: {TotalStalls}");
            Console.WriteLine($"StallRent: {StallRent}");
            Console.WriteLine($"Earning: {Earning}");
            Console.WriteLine($"TotalEarning: {TotalEarning}");
        }

    }
}
