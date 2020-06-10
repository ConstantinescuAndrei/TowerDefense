using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class TowerDefenseException : Exception
    {
        public TowerDefenseException()
        {

        }
        public TowerDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundariesException : TowerDefenseException
    {
        public OutOfBoundariesException()
        {

        }
        public OutOfBoundariesException(string message) : base(message)
        {

        }
    }
}
