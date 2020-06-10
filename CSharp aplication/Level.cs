using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_aplication
{
    class Level
    {
        Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        //Returns true if the player wins or false if he losed
        public bool Play()
        {
            //Level will run until all invaders are neutralized or an invader reaches the base

            int remainingInvaders = _invaders.Length;

            while(remainingInvaders > 0)
            {
                foreach(Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                remainingInvaders = 0;
                foreach(Invader invader in _invaders)
                {
                    if (invader.IsActive())
                    {
                        remainingInvaders++;
                        invader.Move();
                        if (invader.HasScored())
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
