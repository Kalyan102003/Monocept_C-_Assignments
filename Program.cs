    using System;
    using assignment_A;
    using amstrong_number;
    using factorial;
    using prime_number;
    using fibonacci_series;
    class Assignment01
    {
        public static void Main(String[] args)
        {

        /* //reverseing number
         Console.WriteLine("Give some Value to reverse :");
         int R_input = int.Parse(Console.ReadLine());
         ReverseNumber01 rev =new ReverseNumber01();
         Console.WriteLine("Reversed Number : "+rev.ReverseNumber(R_input));/*


        //amstrong
         

         /* 




          amstrong amt = new amstrong();
        Console.WriteLine("Give some Value to check amstrong number or not :");
        int am_input = int.Parse(Console.ReadLine());
        int output = amt.AmstrongNumber(am_input);
        if (am_input == output)
        {
            Console.WriteLine($" {output} it is Amstrong Number ");
        }
        else
        {
            Console.WriteLine($"{output} is not Amstrong Number");
        }




          // fibonacci
        Console.WriteLine("Enter how many Fibonacci numbers:");
        int Fab_input = int.Parse(Console.ReadLine());

        Fibonacci fib = new Fibonacci();
        fib.PrintFibonacci(Fab_input);






         //prime_number
        Console.WriteLine("Give some Value to check prime number :");
        Prime_num P = new Prime_num();
        int P_input = int.Parse(Console.ReadLine());
        int P_output = P.Primee(P_input);
        if (P_output == 2)
        {
            Console.WriteLine($" {P_input}is prime number ");
        }
        else
        {
            Console.WriteLine($" {P_input}is not prime number ");
        }


*/


        //factorial
        Factorial F = new Factorial();
        Console.WriteLine("Give some Value for factorial :");
        int F_input = int.Parse(Console.ReadLine());
        int F_output = F.Value(F_input);
        Console.WriteLine($" Factorial of {F_input} is {F_output} ");






    }
}