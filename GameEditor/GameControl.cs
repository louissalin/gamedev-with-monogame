using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Forms.Controls;
using System.Windows.Forms;

namespace GameEditor
{
    public class GameControl : MonoGameControl
    {
        private Texture2D _texture;
        private bool _cameraDrag;
        private int _mouseX;
        private int _mouseY;

        protected override void Initialize()
        {
            base.Initialize();
            _texture = Editor.Content.Load<Texture2D>("Atlas/ground");

            // load assets
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Middle)
            {
                _cameraDrag = true;
            }

            if (e.Button == MouseButtons.Left)
            {
                // put down a tile
                // TODO
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (e.Button == MouseButtons.Middle)
            {
                _cameraDrag = false;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (_cameraDrag)
            {
                Editor.Cam.Move(new Vector2(_mouseX - e.X, _mouseY - e.Y));
            }

            _mouseX = e.X;
            _mouseY = e.Y;
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw()
        {
            base.Draw();

            Editor.BeginCamera2D();
            Editor.spriteBatch.Draw(_texture, new Rectangle(0, 0, _texture.Width, _texture.Height), Color.White);
            Editor.EndCamera2D();
        }
    }

}
