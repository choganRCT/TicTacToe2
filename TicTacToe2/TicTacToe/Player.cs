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

        public void GetMove(out Math.Vec2 move)
        {
            Console.WriteLine($"\nIt is player {Symbol}'s turn.");
            Console.Write($"Pick a row: ");
            int y = GetUserInput();
            Console.Write($"\nPick a column: ");
            int x = GetUserInput();
            move = new Math.Vec2(x, y);
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