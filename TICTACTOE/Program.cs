namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new TicTacToeFacade();
            Console.WriteLine("Welcome to TicTacToe (console)");
            game.DisplayDetails();

            while (!game.IsGameOver())
            {
                Console.WriteLine($"Player {game.GetCurrentPlayer()} - enter your move");

                Console.Write("Row (0-2): ");
                if (!int.TryParse(Console.ReadLine(), out int row))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                Console.Write("Col (0-2): ");
                if (!int.TryParse(Console.ReadLine(), out int col))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                var result = game.PlaceMove(row, col);
                Console.WriteLine(result.Message);
                game.DisplayDetails();
            }

            if (game.GetWinner() != null)
                Console.WriteLine($"Winner: {game.GetWinner()}");
            else
                Console.WriteLine("Game ended in a draw.");
        }
    }
}
