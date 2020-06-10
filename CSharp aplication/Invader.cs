using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    abstract class Invader : IInvader
    {
        private int _pathStep = 0;
        protected virtual int _stepSize { get; } = 1;
        private readonly Path _path;
       

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public abstract int Health { get; protected set; } 

        public bool HasScored() => _path.HasScored(_pathStep) == true ? true : false;

        public bool IsNeutralized() => (Health <= 0) ? true : false;

        public bool IsActive() => (IsNeutralized() == false && HasScored() == false);

        public Invader(Path path)
        {            
            _path = path;
        }

        public void Move() => _pathStep += _stepSize;

        public virtual void DeacreasedHealth(int factor) => Health -= factor;
    
    }
}
