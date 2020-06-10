using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class Map
    {

        private int Hight;
        private int Width;

        public Map(int width, int hight)
        {
            Width = width;
            Hight = hight;
        }

        public bool OnMap(Point point)
        {
            return  point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Hight;
        }
    }
}
