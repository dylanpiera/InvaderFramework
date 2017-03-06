using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class PlayingState : GameObjectList
    {
        GameObjectList invaders, bullets;
        Player player;
        Score score;
        public PlayingState()
        {
            this.invaders = new GameObjectList(0, "invaders");
            this.bullets = new GameObjectList(0, "bullets");
            this.player = new Player();
            this.score = new Score();
            

            for (int i = 0; i < 9; i++)
            {
                this.invaders.Add(new Invader(i, 0,"blue_invader"));
                this.invaders.Add(new Invader(i, 64, "yellow_invader"));
                this.invaders.Add(new Invader(i, 128, "red_invader"));
            }

            this.Add(new SpriteGameObject("background"));
            this.Add(score);
            this.Add(player);
            this.Add(bullets);
            this.Add(invaders);
        }

        public GameObjectList Bullets
        {
            get
            {
                return bullets;
            }

            set
            {
                bullets = value;
            }
        }

        internal Player Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        internal Score Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }
    }
}
