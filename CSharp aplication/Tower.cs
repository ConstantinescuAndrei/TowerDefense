using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; }  = 1;
        protected virtual double Accuracy { get; }  = 0.75;

        protected MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void SetLocation(MapLocation location)
        {
            _location = _location;
        }

        private bool IsSuccessfullShot()
        {
            return Random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            int index = 0;

            foreach(Invader invader in invaders)
            {
                if (invader.IsActive() && _location.IsInRange(invader.Location, Range) && IsSuccessfullShot())
                {
                    invader.DeacreasedHealth(Power);
                    Console.WriteLine("Shot an invader and hit!!");

                    if (invader.IsNeutralized())
                    {
                        Console.WriteLine("Invader death at " + invader.Location + "!");
                    }
                    break;
                }
            }
        }
    }
}
