using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2.Math
{
    class Vec2 // 2d vector
    {
        // Properties: X, Y (int). These properties should be read-only, meaning they should only have get, not set
        public int X { get; }

        public int Y { get; }

        // Constructor that takes x, y arguments
        public Vec2(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Constructor that takes no arguments and sets X and Y to zero
        public Vec2()
        {
            X = 0;
            Y = 0;
        }

        // Methods to perform these operations:
        // 1. Add int value x to the X value of the vector
        public Vec2 AddX(int x)
        {
            return new Vec2(X + x, Y);
        }

        // 2. Add int value y to the Y value of the vector
        public Vec2 AddY(int y)
        {
            return new Vec2(X, Y + y);
        }

        // 3. Add int values x and y to the vector
        public Vec2 Add(Vec2 V)
        {
            return new Vec2(V.X + X, V.Y + Y);
        }

        // 4. Add another Vec2 to the vector
        public Vec2 Add(Vec2 One, Vec2 Two)
        {
            int newX = One.X + Two.X;
            int newY = One.Y + Two.Y;
            Vec2 Three = new Vec2(newX, newY);
            return Three;
        }

        // 5. Subtract int value x from X value of the vector
        public Vec2 SubtractX(int x)
        {
            return new Vec2(X - x, Y);
        }

        // 6. Subtract int value y from Y value of the vector
        public Vec2 SubtractY(int y)
        {
            return new Vec2(X, Y - y);
        }

        // 7. Subtract int values x and y from the vector
        public Vec2 Subtract(int x, int y)
        {
            return new Vec2(X - x, Y - y);
        }

        // 8. Subtract another Vec2 from the vector
        public Vec2 Subtract(Vec2 V)
        {
            return new Vec2(V.X - X, V.Y - Y);
        }

        // 9. Copy the vector
        public Vec2 Copy(Vec2 V)
        {
            return new Vec2(V.X, V.Y);
        }

        // This class is immutable - its values cannot change. The methods above will need to return a new vector that contains the results of the calculation
    }
}