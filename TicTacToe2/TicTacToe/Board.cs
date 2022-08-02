using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe2.Math;

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

        public void PlaceMark(Vec2 move, char symbol)
        {

            spaces[move.X, move.Y] = symbol;
        }

        public bool HasMarkAt(Vec2 move)
        {
            return spaces[move.X, move.Y] != EmptySpace;
        }

        public bool IsOnBoard(Vec2 move)
        {
            return move.X >= 0 && move.X < Size && move.Y >= 0 && move.Y < Size;
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

        public IEnumerable<char[]> GetDimensions()
        {
            throw new NotImplementedException();
        }
    }
}