using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2
{
    class TicTacToeGame
    {
        private readonly string[] space = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private string player = "X";
        private int turnCount = 0;
        private bool winner = false;
        private bool draw = false;

        public void Play()
        {
            while (!winner && !draw)
            {
                DrawBoard();
                GetUserInput();
                draw = CheckForDraw();
                winner = CheckForWin();
                player = ChangePlayer();
            }
        }

        private void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine($"\n\t {space[0]} | {space[1]} | {space[2]}");
            Console.WriteLine("\t-----------");
            Console.WriteLine($"\t {space[3]} | {space[4]} | {space[5]}");
            Console.WriteLine("\t-----------");
            Console.WriteLine($"\t {space[6]} | {space[7]} | {space[8]}");
        }

        private void GetUserInput()
        {
            string choiceText;
            bool validInput = false;
            bool legalMove = false;

            while (!validInput && !legalMove)
            {
                try
                {
                    Console.WriteLine($"\nIt is player {player}'s turn.");
                    Console.Write("Pick a number from the board to place your mark: ");
                    choiceText = Console.ReadLine();

                    bool isParsable = Int32.TryParse(choiceText, out int choice);
                    if (isParsable)
                    {
                        if (choice <= 0 || choice > 9)
                        {
                            validInput = false;
                            Console.WriteLine("Please enter a number between 1-9.");
                        }
                        else
                        {
                            choice--;
                            if (space[choice] == "X" || space[choice] == "O")
                            {
                                choice++;
                                Console.WriteLine($"\n{choice} is already taken.");
                                legalMove = false;
                            }
                            else
                            {
                                space[choice] = player;
                                legalMove = true;
                                validInput = false;
                            }
                        }
                    }
                }
                catch
                {
                    validInput = true;
                }
                turnCount++;
            }
        }

        private bool CheckForDraw()
        {
            if (turnCount == 9)
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine("\nThis game ended in a draw.");
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckForWin()
        {
            if (space[0] == space[1] && space[1] == space[2])
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"\nCongratulations!! {player} won.");
                return true;
            }
            else if (space[3] == space[4] && space[4] == space[5])
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"\nCongratulations!! {player} won.");
                return true;
            }
            else if (space[6] == space[7] && space[7] == space[8])
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"\nCongratulations!! {player} won.");
                return true;
            }
            else if (space[0] == space[3] && space[3] == space[6])
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"\nCongratulations!! {player} won.");
                return true;
            }
            else if (space[1] == space[4] && space[4] == space[7])
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"\nCongratulations!! {player} won.");
                return true;
            }
            else if (space[2] == space[5] && space[5] == space[8])
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"\nCongratulations!! {player} won.");
                return true;
            }
            else if (space[0] == space[4] && space[4] == space[8])
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"\nCongratulations!! {player} won.");
                return true;
            }
            else if (space[2] == space[4] && space[4] == space[6])
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"\nCongratulations!! {player} won.");
                return true;
            }
            else
            {
                return false;
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
    }
}

