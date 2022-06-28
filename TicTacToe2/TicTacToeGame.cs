using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2
{
    class TicTacToeGame
    {
        private readonly char[,] space = new char[1000, 1000];
        private char player = 'X';
        private int turnCount = 0;
        private int gridNumber = 0;

        public void Play()
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
            gridNumber = GetUserInput(3, 1000);
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

        private void InitializeBoard()
        {
            for (int row = 0; row < gridNumber; row++)
            {
                for (int col = 0; col < gridNumber; col++)
                {
                    space[row, col] = ' ';
                }
            }
        }

        private void DrawBoard()
        {
            Console.Clear();
            Console.Write("    ");
            for (int col = 0; col < gridNumber; col++)
            {
                Console.Write(col + "   ");
            }

            Console.WriteLine();

            for (int row = 0; row < gridNumber; row++)
            {
                Console.Write(row + " | ");
                for (int col = 0; col < gridNumber; col++)
                {
                    Console.Write(space[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

        private void GetUserInput()
        {
            bool validInput = false;
            int choiceRow = 0;
            int choiceColumn = 0;

            while (!validInput)
            {
                Console.WriteLine($"\nIt is player {player}'s turn.");
                Console.Write("Pick a row from the board to place your mark: ");
                choiceRow = GetUserInput(0, gridNumber - 1);
                Console.Write("Pick a column from the board to place your mark: ");
                choiceColumn = GetUserInput(0, gridNumber - 1);

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

        private bool CheckForDraw()
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

        private bool CheckForWin()
        {
            int hCells = 0;
            int vCells = 0;
            int dCells = 0;
            int rdCells = 0;

            for (int row = 0; row < gridNumber; row++)
            {
                for (int col = 0; col < gridNumber; col++)
                {
                    if (space[row, col] == player)
                    {
                        hCells++;
                        if (hCells == gridNumber)
                        {
                            Winner();
                            return true;
                        }
                    }
                }
                hCells = 0;
            }
            for (int col = 0; col < gridNumber; col++)
            {
                for (int row = 0; row < gridNumber; row++)
                {
                    if (space[row, col] == player)
                    {
                        vCells++;
                        if (vCells == gridNumber)
                        {
                            Winner();
                            return true;
                        }
                    }
                }
                vCells = 0;
            }
            for (int row = 0; row < gridNumber; row++)
            {
                if (space[row, row] == player)
                {
                    dCells++;
                    if (dCells == gridNumber)
                    {
                        Winner();
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
                        Winner();
                        return true;
                    }
                }
            }
            return false;
        }

        private char ChangePlayer()
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

        private void Winner()
        {
            Console.Clear();
            DrawBoard();
            Console.WriteLine($"\nCongratulations!! {player} won.");
        }

        private void Draw()
        {
            Console.Clear();
            DrawBoard();
            Console.WriteLine("\nThis game ended in a draw.");
        }
    }
}