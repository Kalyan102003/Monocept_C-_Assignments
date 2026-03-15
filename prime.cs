using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    public class Prime_num
    {
        public int Primee(int A)
        {
            int B = 0;
            for (int i = 1; i <= A; i++)
            {
                if (A % i == 0)
                {
                    B++;
                }
            }
            return B;
        }
    }
}