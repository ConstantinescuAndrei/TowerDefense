using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class SuperTower : Tower
    {
        protected override int Range { get; } = 3;
        protected override double Accuracy { get; } = 1;
        public SuperTower(MapLocation location) : base(location)
        { }
    }
}
