using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class PlayingState : GameObjectList
    {
        GameObjectList invaders;
        public PlayingState()
        {
            this.invaders = new GameObjectList(0, "invaders");

            for (int i = 0; i < 9; i++)
            {
                this.invaders.Add(new Invader(i, 0,"blue_invader"));
                this.invaders.Add(new Invader(i, 64, "yellow_invader"));
                this.invaders.Add(new Invader(i, 128, "red_invader"));
            }

            this.Add(new SpriteGameObject("background"));
            this.Add(new Player());
            this.Add(invaders);
        }
    }
}
