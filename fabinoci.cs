using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_series
{
    public class Fibonacci
    {
        public void PrintFibonacci(int n)
        {
            int a = 1, b = 1;

            if (n >= 1)
                Console.Write(a + " ");

            if (n >= 2)
                Console.Write(b + " ");

            for (int i = 3; i <= n; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}