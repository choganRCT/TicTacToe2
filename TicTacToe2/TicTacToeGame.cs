using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2
{
    class TicTacToeGame
    {
        public void Play()
        {
            bool winner = false;
            while (!winner)
            {
                DrawBoard();
                UserInput();
                winner = CheckWinDraw();
                ChangePlayer();
            }
        }

        private void DrawBoard()
        {
            throw new NotImplementedException();
        }
        private void UserInput()
        {
            throw new NotImplementedException();
        }
        private bool CheckWinDraw()
        {
            throw new NotImplementedException();
        }
        private void ChangePlayer()
        {
            throw new NotImplementedException();
        }
    }
}
