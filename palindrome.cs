using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class PalindromeString
    {
        public void Palindromee(string Value)
        {

            string B = string.Empty;
            for (int i = 0; i < Value.Length; i++) 
            {
                B = Value[i] + B;
            }
            

            if (Value == B)
            {
                Console.WriteLine($"{Value} : is a palindrome String");
            }
            else
            {
                Console.WriteLine($"{Value} : is not a palindrome String");
            }

        }
    }
}
