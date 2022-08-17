using System;
using System.Collections.Generic;
using System.Linq;
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
                Console.WriteLine();
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
                Console.WriteLine();
                board.Draw();
                Console.WriteLine($"Winner: {GetWinningSymbol(board)}");
            }
            else
            {
                Console.WriteLine();
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
            var move = player.GetMove();

            while (board.HasMarkAt(move) || !board.IsOnBoard(move))
            {
                if (board.HasMarkAt(move))
                {
                    Console.WriteLine("Board already has a mark at this location");
                }
                if (!board.IsOnBoard(move))
                {
                    Console.WriteLine("Location is out of bounds");
                }

                move = player.GetMove();
            }

            return move;
        }

        private bool HasWinner(Board board)
        {
            return board.GetDimensions()
                .Any(dimension =>
                    dimension.All(x => x != Board.EmptySpace
                    && dimension.GroupBy(x => x).Count() == 1));
        }

        private bool IsDraw(Board board)
        {
            return board.GetDimensions()
                .All(dimension => dimension
                    .Where(x => x != Board.EmptySpace)
                    .GroupBy(x => x).Count() >= 2);
        }

        private char GetWinningSymbol(Board board)
        {
            return board.GetDimensions()
                .Where(dimension =>
                    dimension.All(x => x != Board.EmptySpace
                    && dimension.GroupBy(x => x).Count() == 1))
                .Select(dimension => dimension
                    .GroupBy(x => x)
                    .Select(g => g.Key)
                    .First())
                .First();
        }
    }
}
