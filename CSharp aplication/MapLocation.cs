using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new Exception(this + "is outside the boundaries of the map.");
            }
        }

        public bool IsInRange(MapLocation location, int range)
        {
            return DistanceTo(location.X, location.Y) <= range;
        }
    }
}
