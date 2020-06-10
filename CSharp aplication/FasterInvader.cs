using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class FasterInvader : Invader
    {
        protected override int _stepSize { get; } = 2;

        public override int Health { get; protected set; } = 2;

        public FasterInvader(Path path) : base(path)
        { }

        public override void DeacreasedHealth(int factor)
        {
            base.DeacreasedHealth(factor);
        }
    }
}
