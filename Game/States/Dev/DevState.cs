using Engine2D.Input;
using Engine2D.States;
using Game.Input;
using Game.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using MonoGame.Extended.ViewportAdapters;
using System.Collections.Generic;

namespace Game.States
{
    /// <summary>
    /// Used to test out new things, like particle engines and shooting missiles
    /// </summary>
    public class DevState : BaseGameState
    {
        private const string PlayerAnimationTurnLeft = "Sprites/Animations/FighterSpriteTurnLeft";
        private const string PlayerAnimationTurnRight = "Sprites/Animations/FighterSpriteTurnRight";
        private const string PlayerFighter = "Sprites/Animations/FighterSpriteSheet";
        private PlayerSprite _playerSprite;

        private OrthographicCamera _camera;

        public override void LoadContent()
        {
            var viewportAdapter = new DefaultViewportAdapter(_graphicsDevice);
            _camera = new OrthographicCamera(viewportAdapter);

            _playerSprite = new PlayerSprite(LoadTexture(PlayerFighter),
                                             LoadAnimation(PlayerAnimationTurnLeft),
                                             LoadAnimation(PlayerAnimationTurnRight));

            _playerSprite.Position = new Vector2(0, 0);
        }

        public override void Render(SpriteBatch spriteBatch)
        {
            // parallax parameter affects how movement of camera is applied.
            // with Zero, the position of the camera doesn't change
            // with One, it moves as desired (ie 10 units per update, as written below)
            // with Two, it moves twice as fast
            //var transformMatrix = _camera.GetViewMatrix(Vector2.Zero);
            //var transformMatrix = _camera.GetViewMatrix(Vector2.One); // default
            //var transformMatrix = _camera.GetViewMatrix(Vector2.One * 2);

            var transformMatrix = _camera.GetViewMatrix();

            spriteBatch.Begin(transformMatrix: transformMatrix);
                _playerSprite.Render(spriteBatch);
            spriteBatch.End();
        }

        public override void HandleInput(GameTime gameTime)
        {
            InputManager.GetCommands(cmd =>
            {
                if (cmd is DevInputCommand.DevQuit)
                {
                    NotifyEvent(new BaseGameStateEvent.GameQuit());
                }

                if (cmd is DevInputCommand.DevLeft)
                {
                    _camera.Position += new Vector2(-10.0f, 0);
                }

                if (cmd is DevInputCommand.DevRight)
                {
                    _camera.Position += new Vector2(10.0f, 0);
                }

                if (cmd is DevInputCommand.DevShoot)
                {
                }
            });
        }

        public override void UpdateGameState(GameTime gameTime) 
        {
        }

        protected override void SetInputManager()
        {
            InputManager = new InputManager(new DevInputMapper());
        }
    }
}