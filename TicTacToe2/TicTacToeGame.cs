using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2
{
    class TicTacToeGame
    {
        static readonly string[] space = new string[9] {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
        public void Play()
        {
            bool winner = false;
            bool draw = false;
            while (!winner && !draw)
            {
                DrawBoard();
                Console.ReadLine();
                GetUserInput();
                draw = CheckForDraw();
                winner = CheckForWin();
                ChangePlayer();
            }
        }

        private void DrawBoard()
        {
            Console.WriteLine($"\t {space[0]} | {space[1]} | {space[2]}");
            Console.WriteLine("\t-----------");
            Console.WriteLine($"\t {space[3]} | {space[4]} | {space[5]}");
            Console.WriteLine("\t-----------");
            Console.WriteLine($"\t {space[6]} | {space[7]} | {space[8]}");
        }
        private void GetUserInput()
        {
            throw new NotImplementedException();
        }
        private bool CheckForDraw()
        {
            throw new NotImplementedException();
        }
        private bool CheckForWin()
        {
            throw new NotImplementedException();
        }
        private void ChangePlayer()
        {
            throw new NotImplementedException();
        }
    }
}
