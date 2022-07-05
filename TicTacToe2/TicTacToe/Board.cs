using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2.TicTacToe
{
    class Board
    {
        private char[,] space;
        private int size = 0;

        private void InitializeBoard()
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    space[row, col] = ' ';
                }
            }
        }

        public void DrawBoard()
        {
            Console.Clear();
            Console.Write("    ");
            for (int col = 0; col < size; col++)
            {
                Console.Write(col + "   ");
            }

            Console.WriteLine();

            for (int row = 0; row < size; row++)
            {
                Console.Write(row + " | ");
                for (int col = 0; col < size; col++)
                {
                    Console.Write(space[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
    }
}
