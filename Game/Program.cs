using Engine2D;
using Game.States;
using System;
using System.Globalization;

namespace Game
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        private const int WIDTH = 1280;
        private const int HEIGHT = 720;

        private const string ENGLISH = "en";
        private const string FRENCH = "fr";
        private const string JAPANESE = "ja";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Strings.Culture = CultureInfo.GetCultureInfo(ENGLISH);

            using (var game = new MainGame(WIDTH, HEIGHT, new SplashState()))
            {
                game.IsFixedTimeStep = true;
                game.TargetElapsedTime = TimeSpan.FromSeconds(1.0f / 50);
                game.Run();
            }
        }
    }
}
