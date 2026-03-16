using System;

namespace ArrayOFStuedntsFees
{
    public class FeesArray
    {
        public int[] InputFees = new int[5];
        public int[] CalculatedFees = new int[5];

        public int Counter = 1;

        public void Feesarray()
        {
            for (int i = 0; i < InputFees.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Enter Fee of Student {Counter}: ");
                    int input = int.Parse(Console.ReadLine());

                    if (input < 5000 || input > 10000)
                    {
                        Console.WriteLine("Error: Fees must be between 5000 and 10000. Enter again.");
                    }
                    else
                    {
                       
                        InputFees[i] = input;

                        
                        if (input > 7000)
                        {
                            CalculatedFees[i] = input - (input * 5 / 100);
                        }
                        else
                        {
                            CalculatedFees[i] = input;
                        }

                        Counter++;
                        break;
                    }
                }
            }

            Console.WriteLine("\nOriginal Fees:");
            for (int i = 0; i < InputFees.Length; i++)
            {
                Console.WriteLine(InputFees[i]);
            }

            Console.WriteLine("\nFees After Discount:");
            for (int i = 0; i < CalculatedFees.Length; i++)
            {
                Console.WriteLine(CalculatedFees[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FeesArray obj = new FeesArray();
            obj.Feesarray();

            Console.ReadLine();
        }
    }
}
