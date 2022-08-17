using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe2.Math;

namespace TicTacToe2.TicTacToe
{
    class Game
    {
        public void Play()
        {
            var board = new Board(GetBoardSize());
            var players = new Player[] { new Player('X'), new Player('O') };
            int playerIndex = 0;

            while (!HasWinner(board) && !IsDraw(board))
            {
                var player = players[playerIndex];
                board.Draw();
                board.PlaceMark(GetMove(player, board), player.Symbol);

                playerIndex++;
                if (playerIndex >= players.Length)
                {
                    playerIndex = 0;
                }
            }

            if (HasWinner(board))
            {
                board.Draw();
                Console.WriteLine($"Winner: {GetWinningSymbol(board)}");
            }
            else
            {
                board.Draw();
                Console.WriteLine("Draw");
            }
        }

        private int GetBoardSize()
        {
            Console.WriteLine("Select board size (3 to 99)");
            var input = GetUserInput();

            while (input <= 2 || input > 99)
            {
                Console.WriteLine("Board size must be between 3 and 99");
                input = GetUserInput();
            }

            return input;
        }

        private int GetUserInput()
        {
            int inputValue = 0;
            bool isNumber = false;

            while (!isNumber)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out inputValue))
                {
                    Console.WriteLine($"{input} is not a number");
                    continue;
                }

                isNumber = true;
            }
            return inputValue;
        }

        private Vec2 GetMove(Player player, Board board)
        {
            throw new NotImplementedException();
        }

        private bool HasWinner(Board board)
        {
            throw new NotImplementedException();
        }

        private bool IsDraw(Board board)
        {
            throw new NotImplementedException();
        }

        private char GetWinningSymbol(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
