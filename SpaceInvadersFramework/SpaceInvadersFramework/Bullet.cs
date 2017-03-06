using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class Bullet : SpriteGameObject
    {
        public Bullet(Vector2 startPos,string assetname = "bullet", int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Position = startPos;
            this.Velocity = new Vector2(0, -128);
        }
    }
}
