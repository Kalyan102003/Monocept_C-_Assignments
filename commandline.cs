using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CommandLineNumbers
{
    public class NumberStats
    {
        public void Calculate(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please pass numbers in command line.");
                return;
            }

            int count = args.Length;
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (string arg in args)
            {
                if (!int.TryParse(arg, out int num))
                {
                    Console.WriteLine($"Invalid number: {arg}");
                    return;
                }

                sum += num;

                max = Math.Max(max, num);
                min = Math.Min(min, num);
            }

            double avg = (double)sum / count;

            Console.WriteLine($"Count = {count}");
            Console.WriteLine($"Sum   = {sum}");
            Console.WriteLine($"Avg   = {avg}");
            Console.WriteLine($"Max   = {max}");
            Console.WriteLine($"Min   = {min}");
        }
    }
}
