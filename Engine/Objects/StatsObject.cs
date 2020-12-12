using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Engine2D.Objects
{
    public class StatsObject : BaseTextObject
    {
        public const int MAXIMUM_SAMPLES = 100;

        private Queue<float> _sampleBuffer = new Queue<float>();

        public float FPS { get; set; }
        public float AverageFPS { get; private set; }
        public bool IsRunningSlowly { get; set; }
        public int NbUpdateCalled { get; set; }
        public int NbDrawCalled { get; set; }

        public StatsObject(SpriteFont font) : base(font) 
        {
            NbUpdateCalled = 0;
            NbDrawCalled = 0;
        }

        public void Update(GameTime gameTime)
        {
            NbUpdateCalled++;
            FPS = 1.0f / (float) gameTime.ElapsedGameTime.TotalSeconds;

            _sampleBuffer.Enqueue(FPS);

            if (_sampleBuffer.Count > MAXIMUM_SAMPLES)
            {
                _sampleBuffer.Dequeue();

                var sum = 0.0f;
                foreach (var fps in _sampleBuffer.ToArray())
                {
                    sum += fps;
                }
                AverageFPS = sum / _sampleBuffer.Count;
            }
            else
            {
                AverageFPS = FPS;
            }

            Text = $"FPS: {FPS}" + System.Environment.NewLine;
            Text += $"Avg FPS: {AverageFPS}" + System.Environment.NewLine;
            Text += $"Running Slowly: {IsRunningSlowly}" + System.Environment.NewLine;
            Text += $"Nb Updates: {NbUpdateCalled}" + System.Environment.NewLine;
            Text += $"Nb Draws: {NbDrawCalled}";
        }

        public override void Render(SpriteBatch spriteBatch)
        {
            NbDrawCalled++;
            base.Render(spriteBatch);
        }
    }
}
