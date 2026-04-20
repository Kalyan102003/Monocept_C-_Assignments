using System;
using System.Collections.Generic;

namespace TicTacToe
{
    // Facade providing a simplified interface for playing the game
    internal class TicTacToeFacade
    {
        private readonly TicTacToeBoard board = new TicTacToeBoard();
        private string currentPlayer = "X";
        private bool gameOver = false;
        private string? winner = null;

        public void Reset()
        {
            board.Reset();
            currentPlayer = "X";
            gameOver = false;
            winner = null;
        }

        public MoveResult PlaceMove(int row, int col)
        {
            if (gameOver)
                return new MoveResult(false, "Game is over", winner, board.IsFull(), currentPlayer);

            var (success, message) = board.PlaceMark(row, col, currentPlayer);
            if (!success) return new MoveResult(false, message, null, false, currentPlayer);

            // check for winner
            var w = board.CheckForWinner();
            if (w != null)
            {
                gameOver = true;
                winner = w;
                return new MoveResult(true, $"{w} wins", winner, false, currentPlayer);
            }

            // check for draw
            if (board.IsFull())
            {
                gameOver = true;
                return new MoveResult(true, "Draw", null, true, currentPlayer);
            }

            // switch player
            currentPlayer = currentPlayer == "X" ? "O" : "X";
            return new MoveResult(true, "Move accepted", null, false, currentPlayer);
        }

        public string GetCurrentPlayer() => currentPlayer;
        public bool IsGameOver() => gameOver;
        public string? GetWinner() => winner;

        public void DisplayDetails()
        {
            var b = board.GetBoardCopy();
            for (int r = 0; r < 3; r++)
            {
                var row = new List<string>();
                for (int c = 0; c < 3; c++)
                    row.Add(b[r, c] ?? " ");
                Console.WriteLine(string.Join(" | ", row));
                if (r < 2) Console.WriteLine("---------");
            }
        }
    }

    internal class MoveResult
    {
        public bool Success { get; }
        public string Message { get; }
        public string? Winner { get; }
        public bool Draw { get; }
        public string CurrentPlayer { get; }

        public MoveResult(bool success, string message, string? winner, bool draw, string currentPlayer)
        {
            Success = success;
            Message = message;
            Winner = winner;
            Draw = draw;
            CurrentPlayer = currentPlayer;
        }
    }
}
