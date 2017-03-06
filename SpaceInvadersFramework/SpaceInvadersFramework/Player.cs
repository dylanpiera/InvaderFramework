using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class Player : SpriteGameObject
    {
        public Player(string assetname = "ship", int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Position = new Vector2(SpaceInvaders.Screen.X / 2, SpaceInvaders.Screen.Y - Sprite.Height); 
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            
            if(inputHelper.IsKeyDown(Keys.Left) && (this.position.X > 0))
            {
                this.Position -= new Vector2(5,0);
            }
            if (inputHelper.IsKeyDown(Keys.Right) && (this.position.X < (SpaceInvaders.Screen.X - Sprite.Width)))
            {
                this.Position -= new Vector2(-5, 0);
            }

            if (inputHelper.KeyPressed(Keys.Space))
            {
                PlayingState ps = GameWorld as PlayingState;
                ps.Bullets.Add(new Bullet(this.Position));
            }
        }
    }
}
