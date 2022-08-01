using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe2.Math;

namespace TicTacToe2.Tests
{
    [TestClass]
    public class Vec2Tests
    {
        [TestMethod]
        public void TestAddX()
        {
            {
                var a = new Vec2(1, 1);
                var b = a.AddX(1);
                Assert.AreEqual(2, b.X);
                Assert.AreEqual(1, b.Y);
            }

            {
                var a = new Vec2(37, 5);
                var b = a.AddX(-41);
                Assert.AreEqual(-4, b.X);
                Assert.AreEqual(5, b.Y);
            }

            {
                var a = new Vec2(154, 663);
                var b = a.AddX(0);
                Assert.AreEqual(154, b.X);
                Assert.AreEqual(663, b.Y);
            }
        }

        [TestMethod]
        public void TestAddY()
        {
            {
                var a = new Vec2(1, 1);
                var b = a.AddY(1);
                Assert.AreEqual(1, b.X);
                Assert.AreEqual(2, b.Y);
            }

            {
                var a = new Vec2(37, 5);
                var b = a.AddY(-41);
                Assert.AreEqual(37, b.X);
                Assert.AreEqual(-36, b.Y);
            }

            {
                var a = new Vec2(154, 663);
                var b = a.AddY(0);
                Assert.AreEqual(154, b.X);
                Assert.AreEqual(663, b.Y);
            }
        }

        [TestMethod]
        public void TestAdd()
        {
            {
                var a = new Vec2(1, 1);
                var b = a.Add(1, 1);
                Assert.AreEqual(2, b.X);
                Assert.AreEqual(2, b.Y);
            }

            {
                var a = new Vec2(37, 5);
                var b = a.Add(-41, -30);
                Assert.AreEqual(-4, b.X);
                Assert.AreEqual(-25, b.Y);
            }

            {
                var a = new Vec2(154, 663);
                var b = a.Add(0, 0);
                Assert.AreEqual(154, b.X);
                Assert.AreEqual(663, b.Y);
            }

        }

        [TestMethod]
        public void TestAdd2()
        {
            {
                var a = new Vec2(1, 1);
                var b = new Vec2(2, 3);
                var c = a.Add(b);
                Assert.AreEqual(3, c.X);
                Assert.AreEqual(4, c.Y);
            }

            {
                var a = new Vec2(37, 5);
                var b = new Vec2(-4, -8);
                var c = a.Add(b);
                Assert.AreEqual(33, c.X);
                Assert.AreEqual(-3, c.Y);
            }

            {
                var a = new Vec2(154, 663);
                var b = new Vec2(0, 0);
                var c = a.Add(b);
                Assert.AreEqual(154, c.X);
                Assert.AreEqual(663, c.Y);
            }
        }

        [TestMethod]
        public void TestSubtractX()
        {
            {
                var a = new Vec2(6, 1);
                var b = a.SubtractX(1);
                Assert.AreEqual(5, b.X);
                Assert.AreEqual(1, b.Y);
            }

            {
                var a = new Vec2(37, 5);
                var b = a.SubtractX(-41);
                Assert.AreEqual(78, b.X);
                Assert.AreEqual(5, b.Y);
            }

            {
                var a = new Vec2(154, 663);
                var b = a.SubtractX(0);
                Assert.AreEqual(154, b.X);
                Assert.AreEqual(663, b.Y);
            }
        }

        [TestMethod]
        public void TestSubtractY()
        {
            {
                var a = new Vec2(1, 5);
                var b = a.SubtractY(1);
                Assert.AreEqual(1, b.X);
                Assert.AreEqual(4, b.Y);
            }

            {
                var a = new Vec2(37, 5);
                var b = a.SubtractY(-41);
                Assert.AreEqual(37, b.X);
                Assert.AreEqual(46, b.Y);
            }

            {
                var a = new Vec2(154, 663);
                var b = a.SubtractY(0);
                Assert.AreEqual(154, b.X);
                Assert.AreEqual(663, b.Y);
            }
        }

        [TestMethod]
        public void TestSubtract()
        {
            {
                var a = new Vec2(1, 1);
                var b = a.Subtract(1, 1);
                Assert.AreEqual(0, b.X);
                Assert.AreEqual(0, b.Y);
            }

            {
                var a = new Vec2(37, 5);
                var b = a.Subtract(-41, -30);
                Assert.AreEqual(78, b.X);
                Assert.AreEqual(35, b.Y);
            }

            {
                var a = new Vec2(154, 663);
                var b = a.Subtract(0, 0);
                Assert.AreEqual(154, b.X);
                Assert.AreEqual(663, b.Y);
            }

        }

        [TestMethod]
        public void TestSubtract2()
        {
            {
                var a = new Vec2(7, 15);
                var b = new Vec2(1, 1);
                var c = a.Subtract(b);
                Assert.AreEqual(-6, c.X);
                Assert.AreEqual(-14, c.Y);
            }

            {
                var a = new Vec2(37, 5);
                var b = new Vec2(-41, -8);
                var c = a.Subtract(b);
                Assert.AreEqual(-78, c.X);
                Assert.AreEqual(-13, c.Y);
            }

            {
                var a = new Vec2(154, 663);
                var b = new Vec2(0, 0);
                var c = a.Subtract(b);
                Assert.AreEqual(-154, c.X);
                Assert.AreEqual(-663, c.Y);
            }

        }
        [TestMethod]
        public void TestCopy()
        {
            {
                var a = new Vec2(7, 15);
                var b = a.Copy();
                Assert.AreEqual(7, b.X);
                Assert.AreEqual(15, b.Y);
            }

            {
                var a = new Vec2(-41, -8);
                var b = a.Copy();
                Assert.AreEqual(-41, b.X);
                Assert.AreEqual(-8, b.Y);
            }

            {
                var a = new Vec2(0, 0);
                var b = a.Copy();
                Assert.AreEqual(0, b.X);
                Assert.AreEqual(0, b.Y);
            }
        }
    }
}
