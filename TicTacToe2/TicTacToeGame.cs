using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2
{
    class TicTacToeGame
    {
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

        private void ChooseBoard()
        {
            Console.WriteLine("\nThis grid is user defined.");
            Console.WriteLine("ie.Inputing 3 will result in a grid 3 rows by 3 columns.");
            size = GetUserInput(3, 1000);
            space = new char[size, size];
        }

        private void GetUserInput()
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine($"\nIt is player {player}'s turn.");
                Console.Write("Pick a row from the board to place your mark: ");
                int choiceRow = GetUserInput(0, size - 1);
                Console.Write("Pick a column from the board to place your mark: ");
                int choiceColumn = GetUserInput(0, size - 1);

                if (space[choiceRow, choiceColumn] == 'X' || space[choiceRow, choiceColumn] == 'O')
                {
                    Console.WriteLine($"\n{choiceRow}, {choiceColumn} is already taken.");
                    validInput = false;
                }
                else
                {
                    space[choiceRow, choiceColumn] = player;
                    validInput = true;
                }
            }
            turnCount++;
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
            if (turnCount == (size * size))
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

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (space[row, col] == player)
                    {
                        hCells++;
                        if (hCells == size)
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

            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    if (space[row, col] == player)
                    {
                        vCells++;
                        if (vCells == size)
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

            for (int row = 0; row < size; row++)
            {
                if (space[row, row] == player)
                {
                    dCells++;
                    if (dCells == size)
                    {
                        return true;
                    }
                }
            }
            for (int row = 0; row < size; row++)
            {
                int col = size - row - 1;
                if (space[row, col] == player)
                {
                    rdCells++;
                    if (rdCells == size)
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