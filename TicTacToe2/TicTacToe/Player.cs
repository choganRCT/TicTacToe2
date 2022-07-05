using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2.TicTacToe
{
    class Player
    {
        private char player = 'X'; //Player

        private char ChangePlayer() //Player
        {
            if (player == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }
    }
}
