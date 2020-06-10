using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class ResurrectedInvader : IInvader
    {
        private BasicInvader _resurrectedInvader1;
        private StrongInvader _resurrectedInvader2;

        public MapLocation Location => _resurrectedInvader1.IsNeutralized ? _resurrectedInvader2.Location : _resurrectedInvader1.Location;

        public int Health { get; protected set; }

        public bool HasScored => _resurrectedInvader1.HasScored || _resurrectedInvader2.HasScored ? true : false;

        public bool IsNeutralized { get; }

        public bool IsActive { get; }
        public ResurrectedInvader(Path path)
        {
            _resurrectedInvader1 = new BasicInvader(path);
            _resurrectedInvader2 = new StrongInvader(path);
        }           

        public void Move()
        {

        }
    }
}
