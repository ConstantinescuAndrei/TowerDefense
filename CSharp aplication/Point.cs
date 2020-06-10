using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }

        public int DistanceTo(int x, int y)
        {
             return (int)Math.Sqrt(Math.Pow(x - X, 2) + Math.Pow(y - Y, 2));
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point))
                return false;

            Point that = obj as Point;

            return (this.X == that.X && this.Y == that.Y);
        }
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
