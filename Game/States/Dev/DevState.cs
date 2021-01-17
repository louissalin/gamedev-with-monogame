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
            var transformMatrix = _camera.GetViewMatrix();
            // TODO: try above with parallax of Vector.Zero

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
                    _playerSprite.MoveLeft();
                }

                if (cmd is DevInputCommand.DevRight)
                {
                    _playerSprite.MoveRight();
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