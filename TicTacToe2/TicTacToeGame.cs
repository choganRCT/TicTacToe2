using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe2.TicTacToe;

namespace TicTacToe2
{
    class TicTacToeGame
    {
        private readonly int turnCount = 0;
        private int col;
        private int row;


        public void Play(Board board, Player player)
        {
            bool winner = false;
            bool draw = false;

            ChooseBoard();
            while (!winner && !draw)
            {
                board.Draw();
                GetUserInput(board, player);
                draw = CheckForDraw(board);
                winner = CheckForWin(board, player);
            }
        }

        public void ChooseBoard()
        {
            Console.WriteLine("\nThis grid is user defined.");
            Console.WriteLine("ie.Inputing 3 will result in a grid 3 rows by 3 columns.");
            _ = new Board (GetUserInput(3, 10000));
        }

        public void GetUserInput(Board board, Player player)
        {
            bool validInput = false;
            _ = new Player('X');

            while (!validInput)
            {
                Console.WriteLine($"\nIt is player {player.GetSymbol()}'s turn.");
                Console.WriteLine("Pick a row from the board to place your mark: ");
                row = GetUserInput(0, board.Size - 1);
                Console.WriteLine($"\nIt is player {player.Symbol}'s turn.");
                Console.WriteLine("Pick a column from the board to place your mark: ");
                col = GetUserInput(0, board.Size - 1);

                board.HasMarkAt(row, col);
                board.IsOnBoard(row, col);

                bool moveOk = board.HasMarkAt(row, col) || board.IsOnBoard(row, col);

                if (moveOk)
                {
                    player.GetMove(out row, out col);
                }
            }
        }

        private int GetUserInput(int min, int max)
        {
            int inputValue = 0;
            bool validInputGiven = false;

            while (!validInputGiven)
            {
                Console.Write($"Enter a number between {min} and {max}: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out inputValue))
                {
                    Console.WriteLine($"{input} is not a number");
                    continue;
                }

                if (inputValue < min || inputValue > max)
                {
                    Console.WriteLine($"{inputValue} is not between {min} and {max}");
                    continue;
                }
                validInputGiven = true;
            }
            return inputValue;
        }

        private bool CheckForDraw(Board board) //Game
        {
            if (turnCount == (board.Size * board.Size))
            {
                GameDraw(board);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckForWin(Board board, Player player) //Game
        {
            bool win = CheckHorizontal(board, player) || CheckVertical(board, player) || CheckDiagonals(board, player);

            if (win)
            {
                Winner(board, player);
            }
            return win;
        }

        private bool CheckHorizontal(Board board, Player player) //Game
        {
            int hCells = 0;

            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    if (board.Spaces[row, col] == player.Symbol)
                    {
                        hCells++;
                        if (hCells == board.Size)
                        {
                            return true;
                        }
                    }
                }
                hCells = 0;
            }
            return false;
        }

        private bool CheckVertical(Board board, Player player)  //Game
        {
            int vCells = 0;

            for (int col = 0; col < board.Size; col++)
            {
                for (int row = 0; row < board.Size; row++)
                {
                    if (board.Spaces[row, col] == player.Symbol)
                    {
                        vCells++;
                        if (vCells == board.Size)
                        {
                            return true;
                        }
                    }
                }
                vCells = 0;
            }
            return false;
        }

        private bool CheckDiagonals(Board board, Player player)  //Game
        {
            int dCells = 0;
            int rdCells = 0;

            for (int row = 0; row < board.Size; row++)
            {
                if (board.Spaces[row, row] == player.Symbol)
                {
                    dCells++;
                    if (dCells == board.Size)
                    {
                        return true;
                    }
                }
            }
            for (int row = 0; row < board.Size; row++)
            {
                int col = board.Size - row - 1;
                if (board.Spaces[row, col] == player.Symbol)
                {
                    rdCells++;
                    if (rdCells == board.Size)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void Winner(Board board, Player player) //Game
        {
            Console.Clear();
            board.Draw();
            Console.WriteLine($"\nCongratulations!! {player.Symbol} won.");
        }

        private void GameDraw(Board board) //Game
        {
            Console.Clear();
            board.Draw();
            Console.WriteLine("\nThis game ended in a draw.");
        }
    }
}