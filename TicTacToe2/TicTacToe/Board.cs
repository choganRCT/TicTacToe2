using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2.TicTacToe
{
    class Board
    {
        public int Size { get; }
        public char[,] Spaces;

        public Board(int size)
        {
            Size = size;
            Spaces = new char[Size, Size];
        }

        public void PlaceMark(int x, int y, char symbol)
        {
            Spaces[x, y] = symbol;
        }

        public bool HasMarkAt(int x, int y)
        {
             if (Spaces[x, y] == 'X' || Spaces[x, y] == 'O')
            {
                return true;
            }
            return false;

        }

        public bool IsOnBoard(int x, int y)
        {
            if (x <= Size - 1 && y <= Size - 1)
            {
                return true;
            }
            return false;
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
                    Console.Write(Spaces[x, y]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
    }
}