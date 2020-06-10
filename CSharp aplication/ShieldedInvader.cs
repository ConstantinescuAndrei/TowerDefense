using System
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class ShieldedInvader :  Invader
    {
        public override int Health { get; protected set; } = 2;

        public ShieldedInvader(Path path) : base(path)
        { }

        public override void DeacreasedHealth(int factor)
        {
            if (Random.NextDouble() < .5)
            {
                base.DeacreasedHealth(factor);
            }
            else
            {
                Console.WriteLine("The invader blocked the shot!");
            }
        }

    }
}
