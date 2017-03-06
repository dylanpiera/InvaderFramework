using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class TitleScreenState : GameObjectList
    {
        private TextGameObject text, time;

        public TitleScreenState()
        {
            this.text = new TextGameObject("GameFont");
            this.time = new TextGameObject("GameFont");
            this.text.Text = "Press \"space\" to start the game";
            this.time.Text = "This game took aprox. 64 minutes to make.";
            this.text.Position = new Microsoft.Xna.Framework.Vector2((SpaceInvaders.Screen.X/2) - (this.text.Size.X/2), (SpaceInvaders.Screen.Y / 2) - (this.text.Size.Y / 2));
            this.time.Position = new Microsoft.Xna.Framework.Vector2((SpaceInvaders.Screen.X / 2) - (this.time.Size.X / 2), (SpaceInvaders.Screen.Y / 2) + (this.text.Size.Y/ 2));

            this.Add(time);
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
