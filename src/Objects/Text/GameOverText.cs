﻿using Choppers.Engine.Objects;
using Microsoft.Xna.Framework.Graphics;

namespace Choppers.Objects.Text
{
    public class GameOverText : BaseTextObject
    {
        public GameOverText(SpriteFont font)
        {
            _font = font;
            Text = "Game Over";
        }
    }
}
