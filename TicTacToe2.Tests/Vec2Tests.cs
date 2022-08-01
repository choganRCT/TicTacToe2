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
            }

            {
                var a = new Vec2(1, 1);
                var b = a.AddX(-2);
                Assert.AreEqual(-1, b.X);
            }

            {
                var a = new Vec2(1, 1);
                var b = a.AddX(0);
                Assert.AreEqual(1, b.X);
            }
        }

        [TestMethod]
        public void TestAddY()
        {

        }
    }
}
