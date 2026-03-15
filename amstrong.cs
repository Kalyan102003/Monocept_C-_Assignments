using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amstrong_number
{
    public class amstrong
    {
        public int AmstrongNumber(int numb)
        {
            int temp = numb;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit * digit * digit;
                temp /= 10;
            }
            return sum;
            
        }
    }
}
