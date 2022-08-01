using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2.TicTacToe
{
    class Board
    {
        private static readonly char EmptySpace = ' ';

        public int Size { get; }
        private readonly char[,] spaces;

        public Board(int size)
        {
            Size = size;
            spaces = new char[Size, Size];

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    spaces[x, y] = EmptySpace;
                }
            }
        }

        public void PlaceMark(int x, int y, char symbol)
        {
            spaces[x, y] = symbol;
        }

        public bool HasMarkAt(int x, int y)
        {
            return spaces[x, y] != EmptySpace;
        }

        public bool IsOnBoard(int x, int y)
        {
            return x >= 0 && x < Size && y >= 0 && y < Size;
        }

        public void Draw()
        {
            Console.Write("   ");
            for (int y = 0; y < Size; y++)
            {
                Console.Write(y + "  ");
            }

            Console.WriteLine();

            for (int x = 0; x < Size; x++)
            {
                Console.Write(x + "| ");
                for (int y = 0; y < Size; y++)
                {
                    Console.Write(spaces[x, y]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
    }
}