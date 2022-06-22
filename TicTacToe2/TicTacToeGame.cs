using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2
{
    class TicTacToeGame
    {
        private readonly string[] space = new string[16] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" };
        private string player = "X";
        private int turnCount = 0;
        private int gridNumber;
        private int choice = 0;

        public void Play()
        {
            bool winner = false;
            bool draw = false;

            ChooseBoard();
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
            Console.WriteLine("\n\t1  -  3 x 3 grid");
            Console.WriteLine("\t2  -  4 x 4 grid");
            Console.Write("\nPick the number of the grid you would like to play on:  ");
            gridNumber = GetUserInput(1, 2);
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

        private void DrawBoard()
        {
            if (gridNumber == 1)
            {
                Console.Clear();
                Console.WriteLine($"\n\t {space[0]} | {space[1]} | {space[2]}");
                Console.WriteLine("\t-----------");
                Console.WriteLine($"\t {space[3]} | {space[4]} | {space[5]}");
                Console.WriteLine("\t-----------");
                Console.WriteLine($"\t {space[6]} | {space[7]} | {space[8]}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"\n\t  {space[0]} | {space[1]} | {space[2]} | {space[3]}");
                Console.WriteLine("\t-----------------");
                Console.WriteLine($"\t  {space[4]} | {space[5]} | {space[6]} | {space[7]}");
                Console.WriteLine("\t-----------------");
                Console.WriteLine($"\t  {space[8]} | {space[9]} | {space[10]} | {space[11]}");
                Console.WriteLine("\t-----------------");
                Console.WriteLine($"\t  {space[12]} | {space[13]} | {space[14]} | {space[15]}");
            }

        }

        private void GetUserInput()
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine($"\nIt is player {player}'s turn.");
                Console.Write("Pick a number from the board to place your mark: ");

                if (gridNumber == 1)
                {
                    choice = GetUserInput(1, 9);
                }
                else
                {
                    choice = GetUserInput(1, 16);
                }

                if (space[choice - 1] == "X" || space[choice - 1] == "O")
                {
                    Console.WriteLine($"\n{choice} is already taken.");
                    validInput = false;
                }
                else
                {
                    space[choice - 1] = player;
                    validInput = true;
                }
            }
            turnCount++;
        }

         private bool CheckForDraw()
        {
            if (gridNumber == 1 && turnCount == 9)
            {
                Draw();
                return true;
            }
            else if (gridNumber != 1 && turnCount == 16)
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
            if (gridNumber == 1)
            {
                if (space[0] == space[1] && space[1] == space[2])
                {
                    Winner();
                    return true;
                }
                else if (space[3] == space[4] && space[4] == space[5])
                {
                    Winner();
                    return true;
                }
                else if (space[6] == space[7] && space[7] == space[8])
                {
                    Winner();
                    return true;
                }
                else if (space[0] == space[3] && space[3] == space[6])
                {
                    Winner();
                    return true;
                }
                else if (space[1] == space[4] && space[4] == space[7])
                {
                    Winner();
                    return true;
                }
                else if (space[2] == space[5] && space[5] == space[8])
                {
                    Winner();
                    return true;
                }
                else if (space[0] == space[4] && space[4] == space[8])
                {
                    Winner();
                    return true;
                }
                else if (space[2] == space[4] && space[4] == space[6])
                {
                    Winner();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (space[0] == space[1] && space[1] == space[2] && space[2] == space[4])
                {
                    Winner();
                    return true;
                }
                else if (space[5] == space[6] && space[6] == space[7] && space[7] == space[8])
                {
                    Winner();
                    return true;
                }
                else if (space[9] == space[10] && space[10] == space[11] && space[11] == space[12])
                {
                    Winner();
                    return true;
                }
                else if (space[13] == space[14] && space[14] == space[15] && space[15] == space[16])
                {
                    Winner();
                    return true;
                }
                else if (space[0] == space[4] && space[4] == space[8] && space[8] == space[12])
                {
                    Winner();
                    return true;
                }
                else if (space[1] == space[5] && space[5] == space[9] && space[9] == space[13])
                {
                    Winner();
                    return true;
                }
                else if (space[2] == space[6] && space[6] == space[10] && space[10] == space[14])
                {
                    Winner();
                    return true;
                }
                else if (space[3] == space[7] && space[7] == space[11] && space[11] == space[15])
                {
                    Winner();
                    return true;
                }
                else if (space[0] == space[5] && space[5] == space[10] && space[10] == space[15])
                {
                    Winner();
                    return true;
                }
                else if (space[3] == space[6] && space[6] == space[9] && space[9] == space[12])
                {
                    Winner();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private string ChangePlayer()
        {
            if (player == "X")
            {
                return "O";
            }
            else
            {
                return "X";
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