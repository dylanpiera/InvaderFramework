﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class PlayingState : GameObjectList
    {
        public PlayingState()
        {
            this.Add(new SpriteGameObject("background"));
        }
    }
}
