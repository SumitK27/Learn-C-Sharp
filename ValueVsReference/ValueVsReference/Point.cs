using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReference
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public void Move(Point newLocation)
        {
            X = newLocation.X;
            Y = newLocation.Y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
