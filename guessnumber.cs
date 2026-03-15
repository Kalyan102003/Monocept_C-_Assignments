using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame
{
    public class GuessNumber
    {
        public Random rnd = new Random();
        public int number;
        public GuessNumber()
        {
            number = rnd.Next(1, 101);
        }

        public void GuessTheNumber(int input) {

            while (number != input)

            {
                
                    if(input > number)
                {
                    Console.WriteLine("Number is high, enter another number");
                    input = int.Parse(Console.ReadLine());
                }
                else if(input < number)
                {
                    Console.WriteLine("Number is low, enter another number");
                    input = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"Congratulations,{input} is correct guess");
            
        }
    }
}
