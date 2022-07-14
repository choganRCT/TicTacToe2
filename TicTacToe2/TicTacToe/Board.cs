using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2.TicTacToe
{
    class Board
    {
        public static int Size { get; set; }
        public static char[,] Space { get; private set; }

        public bool validInput = false;

        public Board(int size)
        {
            Size = size;
        }

        public static void InitializeBoard()
        {
            InitializeBoard(Space);
        }

        public static void InitializeBoard(char[,] Space)
        {

            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    Space[x, y] = ' ';
                }
            }
        }

        public void PlaceMark(int x, int y, char symbol)
        {
            Space[x, y] = symbol;
        }

        public bool HasMarkAt(int x, int y)
        {
            if (Space[x, y] == 'X' || Space[x, y] == 'O')
            {
                Console.WriteLine($"\n{x}, {y} is already taken.");
                validInput = false;
            }
            return validInput;
        }

        /*public bool IsOnBoard (int x, int y) 
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine($"\nIt is player {symbol}'s turn.");
                Console.Write("Pick a row from the board to place your mark: ");
                int x = GetUserInput(0, Board.Size - 1);
                Console.Write("Pick a column from the board to place your mark: ");
                int y = GetUserInput(0, Board.Size - 1);
            }
            validInput = true;

        }*/

        public static void Draw()
        {
            for (int y = 0; y < Size; y++)
            {
                Console.Write(y + "   ");
            }

            Console.WriteLine();

            for (int x = 0; x < Size; x++)
            {
                Console.Write(x + " | ");
                for (int y = 0; y < Size; y++)
                {
                    Console.Write(Space[x, y]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
            Console.Clear();
            Console.Write("    ");
        }

    }
}