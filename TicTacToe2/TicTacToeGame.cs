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
                GetUserInput();
                CheckForDraw();
                winner = CheckForWin();
                ChangePlayer();
            }
        }

        private void DrawBoard()
        {
            throw new NotImplementedException();
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
