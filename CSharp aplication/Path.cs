using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class Path
    {
        private readonly MapLocation[] path;

        public Path(MapLocation[] path)
        {
            this.path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < path.Length) ? path[pathStep] : null;
        }

        public bool HasScored(int pathStep) =>  (pathStep == path.Length - 1) ? true : false;
       
        public bool IsOnPath(MapLocation location)
        {
            foreach(var pathLocation in path)
            {
                if(pathLocation.Equals(location))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
