using Engine2D;
using Game.States;
using System;

namespace Game
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        private const int WIDTH = 1280;
        private const int HEIGHT = 720;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new MainGame(WIDTH, HEIGHT, new SplashState()))
            {
                game.IsFixedTimeStep = true;
                game.TargetElapsedTime = TimeSpan.FromSeconds(1.0f / 50);
                game.Run();
            }
        }
    }
}
