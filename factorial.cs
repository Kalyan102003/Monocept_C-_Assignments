using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    public class Factorial
    {
        public int Value(int A)
        {
            int B = 1;
            for (int i = 1; i <= A; i++) {
                B = B * i;

            }
            return B;

        }
    }
}
