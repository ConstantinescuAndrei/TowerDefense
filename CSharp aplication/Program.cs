
using System;

namespace CSharp_aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new[]
                    {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map)
                    }
                );

                MapLocation _location = new MapLocation(0, 2, map);

                /*if (path.IsOnPath(_location))
                {
                    Console.WriteLine("it is");
                    return;
                }
                */

                Invader[] invaders =
                {
                    new ShieldedInvader(path),
                    new BasicInvader(path),
                    new ShieldedInvader(path),
                    new BasicInvader(path),
                    new FasterInvader(path),
                    new ShieldedInvader(path),
                    new BasicInvader(path)
                 };

                Tower[] towers =
                {
                    new Tower(new MapLocation(1, 3, map)),
                    new Tower(new MapLocation(3, 3, map)),
                    new Tower(new MapLocation(5, 3, map)),
                    new Tower(new MapLocation(5, 3, map)),
                    new Tower(new MapLocation(5, 3, map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine(playerWon ? "won" : "lose");

                Random random = new Random();
                random.Next();

                Console.WriteLine(random);
                Console.WriteLine(random.NextDouble() * 100);
                Console.WriteLine(random.Next());
            
        }
           
            
            catch(Exception ex)
             {
                 Console.WriteLine("Out of the map boundaries " + ex);
             }

            


        }
    }
}
