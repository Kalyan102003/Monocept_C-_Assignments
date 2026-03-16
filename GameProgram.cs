using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dice_Game
{
    public class GameProgram
    {
        public string UserInput;
        public int RoundCounter =1;
        public int DiceCounter =0;

        public void Game()
        {


            Console.WriteLine("Do you Wants to Roll/Hold? (R/H)");

            UserInput = Console.ReadLine();

            if (DiceCounter < 20)
            {

                if (UserInput == "R")
                {
                    Roll();

                }
                else
                {
                    hold();
                }

            }
            else
            {
                Console.WriteLine($"Congratulations you win with {DiceCounter} points in {RoundCounter} rounds.");
            }
        }
        public void Roll()
        {
            if (DiceCounter < 20)
            {
                int dice = new Random().Next(1, 7);
                Console.WriteLine($"Die : {dice}");
                if (dice == 1)

                {
                    Console.WriteLine("You Lost your turn is over.");
                    DiceCounter = 0;
                    RoundCounter+=1;
                    Game();
                }
                else
                {
                    DiceCounter += dice;
                    Game();
                }
            }
            else
            {
                Console.WriteLine($"Congratulations you win with {DiceCounter} points in {RoundCounter} rounds.");
            }

            
        }

        public void hold()
            {
                Console.WriteLine($"Your Score is : {DiceCounter}");
                 RoundCounter += 1;
            if (DiceCounter >= 20)
            {
                Console.WriteLine($"Congratulations you win with {DiceCounter} points in {RoundCounter} rounds.");
            }
            else { Game(); }
           
            }

        }



        }



namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameProgram G = new GameProgram();
            G.Game();
        }
    }
}


