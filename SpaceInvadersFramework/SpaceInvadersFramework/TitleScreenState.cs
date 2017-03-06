using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class TitleScreenState : GameObjectList
    {
        private TextGameObject text;

        public TitleScreenState()
        {
            this.text = new TextGameObject("GameFont");
            this.text.Text = "Press \"space\" to start the game";
            this.text.Position = new Microsoft.Xna.Framework.Vector2((SpaceInvaders.Screen.X/2)-(this.text.Size.X/2), (SpaceInvaders.Screen.Y / 2) - (this.BoundingBox.Height / 2));
            this.Add(text);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if(inputHelper.KeyPressed(Microsoft.Xna.Framework.Input.Keys.Space))
            {
                SpaceInvaders.GameStateManager.SwitchTo(SpaceInvaders.playingState);
            }
        }

    }
}
