using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    interface IMoveble
    {
        void Move();
    }
    interface IMapable
    {
        MapLocation Location { get; }
    }
    interface IInvader : IMapable, IMoveble
    {

        int Health { get; protected set; }

        bool HasScored { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }
    }
}
