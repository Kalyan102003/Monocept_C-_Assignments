using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace TicTacToe
{
    // Core board logic encapsulated in a separate class
    internal class TicTacToeBoard
    {
        private readonly string?[,] board = new string?[3, 3];

        public TicTacToeBoard()
        {
            Reset();
        }

        public void Reset()
        {
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    board[r, c] = null;
        }

        public string?[,] GetBoardCopy()
        {
            var copy = new string?[3, 3];
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    copy[r, c] = board[r, c];
            return copy;
        }

        public bool IsCellEmpty(int row, int col)
        {
            return board[row, col] == null;
        }

        public (bool Success, string Message) PlaceMark(int row, int col, string symbol)
        {
            if (row < 0 || row > 2 || col < 0 || col > 2)
                return (false, "Row and column must be in range 0..2");

            if (symbol != "X" && symbol != "O")
                return (false, "Invalid symbol");

            if (board[row, col] != null)
                return (false, "Cell already occupied");

            board[row, col] = symbol;
            return (true, "Move accepted");
        }

        public string? CheckForWinner()
        {
            var players = new[] { "X", "O" };
            foreach (var s in players)
            {
                // rows
                for (int r = 0; r < 3; r++)
                    if (board[r, 0] == s && board[r, 1] == s && board[r, 2] == s) return s;

                // cols
                for (int c = 0; c < 3; c++)
                    if (board[0, c] == s && board[1, c] == s && board[2, c] == s) return s;

                // diagonals
                if (board[0, 0] == s && board[1, 1] == s && board[2, 2] == s) return s;
                if (board[0, 2] == s && board[1, 1] == s && board[2, 0] == s) return s;
            }

            return null;
        }

        public bool IsFull()
        {
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    if (board[r, c] == null) return false;
            return true;
        }
    }
}
