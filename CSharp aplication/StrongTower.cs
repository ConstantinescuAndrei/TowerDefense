using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class StrongTower : Tower
    {
        protected override int Power { get; } = 2;
        public StrongTower(MapLocation location) : base(location)
        { }
    }
}
