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

        }
    }
}
