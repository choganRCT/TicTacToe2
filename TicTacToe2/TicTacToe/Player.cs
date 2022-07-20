using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2.TicTacToe
{
    class Player
    {
        public int row;
        public int col;

        public char Symbol { get; }

        public Player(char symbol)
        {
            Symbol = symbol;
        }

        public void GetMove(out int x, out int y)
        {
            x = row;
            y = col;
        }

        public char GetSymbol()
        {
            return Symbol;
        }
    }
}
