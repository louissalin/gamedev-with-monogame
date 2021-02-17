using Microsoft.Xna.Framework.Content;
using PipelineExtensions;
using System;

namespace GameEditor
{
    public class Level
    {
        public const int LEVEL_LENGTH = 100;
        public const int LEVEL_WIDTH = 10;

        public string[,] GroundGrid { get; set; }
        public string[,] BuildingGrid { get; set; }
        public string[,] ObjectGrid { get; set; }


        public Level()
        {
            GroundGrid = new string[LEVEL_WIDTH, LEVEL_LENGTH];
            BuildingGrid = new string[LEVEL_WIDTH, LEVEL_LENGTH];
            ObjectGrid = new string[LEVEL_WIDTH, LEVEL_LENGTH];
        }

        public void Save(int levelNb)
        {
            var levelData = new GameEditorLevelData(LEVEL_WIDTH, LEVEL_LENGTH, GroundGrid, BuildingGrid, ObjectGrid);
            levelData.Save(levelNb);
        }

        public void Load(ContentManager content, int currentLevel)
        {
            var levelData = content.Load<GameEditorLevelData>($"levels/Level{currentLevel}");
            GroundGrid = levelData.StringToArray(levelData.GroundGrid);
            BuildingGrid = levelData.StringToArray(levelData.BuildingGrid);
            ObjectGrid = levelData.StringToArray(levelData.ObjectGrid);
        }
    }
}
