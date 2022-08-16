using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe2.Math;
using TicTacToe2.TicTacToe;

namespace TicTacToe2.Tests
{
    [TestClass]
    public class BoardTests
    {
        private Board CreateBoardA()
        {
            var board = new Board(3);
            board.PlaceMark(new Vec2(1, 1), 'X');
            board.PlaceMark(new Vec2(0, 0), 'O');
            board.PlaceMark(new Vec2(2, 0), 'X');
            board.PlaceMark(new Vec2(2, 1), 'O');
            board.PlaceMark(new Vec2(1, 0), 'X');
            board.PlaceMark(new Vec2(0, 2), 'O');
            board.PlaceMark(new Vec2(1, 2), 'X');

            return board;
        }

        [TestMethod]
        public void TestGetDimensions()
        {
            var board = CreateBoardA();
            var dimensions = board.GetDimensions();

            Assert.AreEqual(8, dimensions.Count(), "Incorrect dimensions length");

            var accurateDimensions = new List<char[]>()
            {
                new char[] { 'O', 'X', 'X' },
                new char[] { Board.EmptySpace, 'X', 'O' },
                new char[] { 'O', 'X', Board.EmptySpace },
                new char[] { 'O', Board.EmptySpace, 'O' },
                new char[] { 'X', 'X', 'X' },
                new char[] { 'X', 'O', Board.EmptySpace },
                new char[] { 'O', 'X', Board.EmptySpace },
                new char[] { 'X', 'X', 'O' }
            };

            var dimensionsList = dimensions.ToList();

            for (int i = 0; i < accurateDimensions.Count; i++)
            {
                Assert.IsTrue(AreEqual(dimensionsList[i], accurateDimensions[i]), $"Dimensions {i} do not match");
            }
        }

        private bool AreEqual(char[] a, char[] b)
        {
            var equal = a.Length == b.Length;

            if (equal)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    equal = equal && a[i] == b[i];
                }
            }

            return equal;
        }
    }
}
