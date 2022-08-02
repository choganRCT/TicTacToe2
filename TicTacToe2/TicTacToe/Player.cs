using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe2.Math;

namespace TicTacToe2.TicTacToe
{
    class Player
    {
        public char Symbol { get; }

        public Player(char symbol)
        {
            Symbol = symbol;
        }

        public void Vec2()
        {
            Console.WriteLine($"\nIt is player {Symbol}'s turn.");
            Console.Write($"Pick a row: ");
            int y = GetUserInput();
            Console.Write($"\nPick a column: ");
            int x = GetUserInput();
            _ = new Vec2(x, y);
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