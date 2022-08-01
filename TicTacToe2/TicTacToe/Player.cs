using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2.TicTacToe
{
    class Player
    {
        public char Symbol { get; }

        public Player(char symbol)
        {
            Symbol = symbol;
        }

        public void GetMove(out int x, out int y)
        {
            Console.WriteLine($"\nIt is player {Symbol}'s turn.");
            Console.Write($"Pick a row: ");
            y = GetUserInput();
            Console.Write($"\nPick a column: ");
            x = GetUserInput();
        }

        private int GetUserInput()
        {
            int inputValue = 0;
            bool isNumber = false;

            while (!isNumber)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out inputValue))
                {
                    Console.WriteLine($"{input} is not a number");
                    continue;
                }

                isNumber = true;
            }
            return inputValue;
        }
    }
}