using CommandLineNumbers;
using GuessTheNumberGame;
using loops;
using Palindrome;
using ArrayTest;
using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Enter a value to check palindrome or not:");
        string P_input = Console.ReadLine();
        PalindromeString P = new PalindromeString();
        P.Palindromee(P_input);


        NumberStats stats = new NumberStats();
        stats.Calculate(args);


        Console.WriteLine($"Enter a value to guess the number :");
        int G_input = int.Parse(Console.ReadLine());
        GuessNumber G = new GuessNumber();
        G.GuessTheNumber(G_input);


        ForWhileLoops F = new ForWhileLoops();
        Console.WriteLine($"Enter a value to print from For and while loop :");
        string F_input = Console.ReadLine();
        F.ForLoop(F_input);


        ArrayPractice A = new ArrayPractice();
        A.Arrayy();



    }
}