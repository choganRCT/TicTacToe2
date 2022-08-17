using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe2.Math;

namespace TicTacToe2.TicTacToe
{
    public class Board
    {
        public static readonly char EmptySpace = ' ';

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
            for (int x = 0; x < Size; x++)
            {
                Console.Write($" {x} ");
            }

            Console.WriteLine();

            for (int y = 0; y < Size; y++)
            {
                Console.Write(y + "| ");
                for (int x = 0; x < Size; x++)
                {
                    Console.Write(spaces[x, y]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

        public IEnumerable<char[]> GetDimensions()
        {
            var dimensions = new List<char[]>();

            // rows
            for (int y = 0; y < Size; y++)
            {
                var row = new char[Size];
                for (int x = 0; x < Size; x++)
                {
                    row[x] = spaces[x, y];
                }
                dimensions.Add(row);
            }

            // columns
            for (int x = 0; x < Size; x++)
            {
                var row = new char[Size];
                for (int y = 0; y < Size; y++)
                {
                    row[y] = spaces[x, y];
                }
                dimensions.Add(row);
            }

            // diagonal down
            var diagonalDown = new char[Size];
            for (int x = 0, y = 0, i = 0; x < Size && y < Size; x++, y++, i++)
            {
                diagonalDown[i] = spaces[x, y];
            }
            dimensions.Add(diagonalDown);

            // diagonal up
            var diagonalUp = new char[Size];
            for (int x = 0, y = Size - 1, i = 0; x < Size && y >= 0; x++, y--, i++)
            {
                diagonalUp[i] = spaces[x, y];
            }
            dimensions.Add(diagonalUp);

            return dimensions;
        }
    }
}