using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2
{
    class TicTacToeGame
    {
       
        private char player = 'X'; //Player
        private int turnCount = 0; //Game
       

        public void Play()  //Game
        {
            bool winner = false;
            bool draw = false;

            ChooseBoard();
            InitializeBoard();
            while (!winner && !draw)
            {
                DrawBoard();
                GetUserInput();
                draw = CheckForDraw();
                winner = CheckForWin();
                player = ChangePlayer();
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
            if (turnCount == (gridNumber * gridNumber))
            {
                Draw();
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

            for (int row = 0; row < gridNumber; row++)
            {
                for (int col = 0; col < gridNumber; col++)
                {
                    if (space[row, col] == player)
                    {
                        hCells++;
                        if (hCells == gridNumber)
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

            for (int col = 0; col < gridNumber; col++)
            {
                for (int row = 0; row < gridNumber; row++)
                {
                    if (space[row, col] == player)
                    {
                        vCells++;
                        if (vCells == gridNumber)
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

            for (int row = 0; row < gridNumber; row++)
            {
                if (space[row, row] == player)
                {
                    dCells++;
                    if (dCells == gridNumber)
                    {
                        return true;
                    }
                }
            }
            for (int row = 0; row < gridNumber; row++)
            {
                int col = gridNumber - row - 1;
                if (space[row, col] == player)
                {
                    rdCells++;
                    if (rdCells == gridNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private char ChangePlayer() //Player
        {
            if (player == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }

        private void Winner() //Game
        {
            Console.Clear();
            DrawBoard();
            Console.WriteLine($"\nCongratulations!! {player} won.");
        }

        private void Draw() //Game
        {
            Console.Clear();
            DrawBoard();
            Console.WriteLine("\nThis game ended in a draw.");
        }
    }
}