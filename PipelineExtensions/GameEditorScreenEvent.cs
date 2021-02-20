namespace PipelineExtensions
{
    public class GameEditorScreenEvent
    {
        public class GameEditorGenerateEnemies : GameEditorScreenEvent
        { 
            public int NbEnemies { get; set; }

            public GameEditorGenerateEnemies()
            {
            }
        }
    }
}
