using Game.Engine.Objects;
using Microsoft.Xna.Framework.Graphics;

namespace Game.Objects
{
    public class SplashImage : BaseGameObject
    {
        public SplashImage(Texture2D texture)
        {
            _texture = texture;
        }
    }
}