using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe2.TicTacToe;

namespace TicTacToe2
{
    class TicTacToeGame
    {
        private readonly int turnCount = 0;
        private char symbol = 'X';

        public void Play()
        {
            bool winner = false;
            bool draw = false;

            ChooseBoard();
            Board.InitializeBoard();
            while (!winner && !draw)
            {
                Board.Draw();
                //GetUserInput();
                draw = CheckForDraw();
                winner = CheckForWin();
                symbol = ChangePlayer();
            }
        }

        private void ChooseBoard()
        {
            Console.WriteLine("\nThis grid is user defined.");
            Console.WriteLine("ie.Inputing 3 will result in a grid 3 rows by 3 columns.");
            Board.Size = GetUserInput(3, 1000);

        }


        /*public void GetUserInput()
        {
  
        }*/

        /*public void DrawBoard()
        {
 
        }*/

        private char ChangePlayer() //Player
        {
            if (symbol == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
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

        private bool CheckForDraw() //Game
        {
            if (turnCount == (Board.Size * Board.Size))
            {
                GameDraw();
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckForWin() //Game
        {
            bool win = CheckHorizontal() || CheckVertical() || CheckDiagonals();

            if (win)
            {
                Winner();
            }
            return win;
        }

        private bool CheckHorizontal() //Game
        {
            int hCells = 0;

            for (int row = 0; row < Board.Size; row++)
            {
                for (int col = 0; col < Board.Size; col++)
                {
                    if (Board.Space[row, col] == symbol)
                    {
                        hCells++;
                        if (hCells == Board.Size)
                        {
                            return true;
                        }
                    }
                }
                hCells = 0;
            }
            return false;
        }

        private bool CheckVertical()  //Game
        {
            int vCells = 0;

            for (int col = 0; col < Board.Size; col++)
            {
                for (int row = 0; row < Board.Size; row++)
                {
                    if (Board.Space[row, col] == symbol)
                    {
                        vCells++;
                        if (vCells == Board.Size)
                        {
                            return true;
                        }
                    }
                }
                vCells = 0;
            }
            return false;
        }

        private bool CheckDiagonals()  //Game
        {
            int dCells = 0;
            int rdCells = 0;

            for (int row = 0; row < Board.Size; row++)
            {
                if (Board.Space[row, row] == symbol)
                {
                    dCells++;
                    if (dCells == Board.Size)
                    {
                        return true;
                    }
                }
            }
            for (int row = 0; row < Board.Size; row++)
            {
                int col = Board.Size - row - 1;
                if (Board.Space[row, col] == symbol)
                {
                    rdCells++;
                    if (rdCells == Board.Size)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void Winner() //Game
        {
            Console.Clear();
            Board.Draw();
            Console.WriteLine($"\nCongratulations!! {symbol} won.");
        }

        private void GameDraw() //Game
        {
            Console.Clear();
            Board.Draw();
            Console.WriteLine("\nThis game ended in a draw.");
        }
    }
}