using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2.TicTacToe
{
    class Player
    {

        public Player(char symbol)
        {
            Symbol = symbol;
        }

        public void GetMove(out int x, out int y)  //we need to return multiple values
        {
            x = 0;
            y = 0;
        }

        public char GetSymbol()
        {
            if (Symbol == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }

        public char Symbol { get; }
    }
}
