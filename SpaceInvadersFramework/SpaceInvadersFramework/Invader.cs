using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SpaceInvadersFramework
{
    class Invader : SpriteGameObject
    {
        public Invader(float hposOffset, float vposOffset, string assetname, int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Position = new Vector2((Sprite.Width * hposOffset)+(8 * hposOffset), vposOffset);
            this.Velocity = new Vector2(2,0);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if(this.Position.X >= (SpaceInvaders.Screen.X - Sprite.Width))
            {
                this.Velocity = new Vector2(-2,0);
                this.Position -= new Vector2(0, -32);
            }
            if(this.position.X < 0)
            {
                this.Velocity = new Vector2(2, 0);
                this.Position -= new Vector2(0, -32);
            }

            this.Position += this.Velocity;
        }
    }
}
