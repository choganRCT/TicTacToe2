using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2.TicTacToe
{
    class Board
    {
        private char[,] space; //Board
        private int gridNumber = 0; //Board

        private void ChooseBoard() //Board
        {
            Console.WriteLine("\nThis grid is user defined.");
            Console.WriteLine("ie.Inputing 3 will result in a grid 3 rows by 3 columns.");
            gridNumber = GetUserInput(3, 1000);
            space = new char[gridNumber, gridNumber];
        }

        private void InitializeBoard() //Board
        {
            for (int row = 0; row < gridNumber; row++)
            {
                for (int col = 0; col < gridNumber; col++)
                {
                    space[row, col] = ' ';
                }
            }
        }

        private void DrawBoard()  //Board
        {
            Console.Clear();
            Console.Write("    ");
            for (int col = 0; col < gridNumber; col++)
            {
                Console.Write(col + "   ");
            }

            Console.WriteLine();

            for (int row = 0; row < gridNumber; row++)
            {
                Console.Write(row + " | ");
                for (int col = 0; col < gridNumber; col++)
                {
                    Console.Write(space[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
        private void GetUserInput()
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine($"\nIt is player {player}'s turn.");
                Console.Write("Pick a row from the board to place your mark: ");
                int choiceRow = GetUserInput(0, gridNumber - 1);
                Console.Write("Pick a column from the board to place your mark: ");
                int choiceColumn = GetUserInput(0, gridNumber - 1);

                if (space[choiceRow, choiceColumn] == 'X' || space[choiceRow, choiceColumn] == 'O')
                {
                    Console.WriteLine($"\n{choiceRow}, {choiceColumn} is already taken.");
                    validInput = false;
                }
                else
                {
                    space[choiceRow, choiceColumn] = player;
                    validInput = true;
                }
            }
            turnCount++;
        }
    }
}
