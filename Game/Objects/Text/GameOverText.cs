using Engine2D.Objects;
using Microsoft.Xna.Framework.Graphics;

namespace Game.Objects.Text
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
