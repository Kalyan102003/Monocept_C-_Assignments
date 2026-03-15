using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    public class ForWhileLoops
    {
        public void ForLoop(string input)
        {

            Console.WriteLine("Using FOR loop:");
            for (int i = 0; i < input.Length; i++) 
            { 
                    Console.WriteLine(input[i]); 
            }
            Console.WriteLine("\nUsing WHILE loop:");
            int j = 0;
            while (j < input.Length)
            {
                Console.WriteLine(input[j]);
                j++;
            }
        }
    }
}
