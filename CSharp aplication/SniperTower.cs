using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 3;
        public SniperTower(MapLocation location) : base(location)
        { }
    }
}
