using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Intermediate;
using System.Linq;
using System.Xml;

namespace PipelineExtensions
{
    public class GameEditorLevelData
    {
        public string GroundGrid { get; set; }
        public string BuildingGrid { get; set; }
        public string ObjectGrid { get; set; }

        public int GridWidth { get; set; }
        public int GridLength { get; set; }


        public GameEditorLevelData(int gridWidth, int gridLength, 
                                   string[,] groundGrid, string[,] buildingGrid, 
                                   string[,] objectGrid)
        {
            GridLength = gridLength;
            GridWidth = gridWidth;

            GroundGrid = ArrayToString(groundGrid);
            BuildingGrid = ArrayToString(buildingGrid);
            ObjectGrid = ArrayToString(objectGrid);
        }

        private string ArrayToString(string[,] grid)
        {
            var lines = new string[GridLength];

            for (var y = 0; y < GridLength; y++)
            {
                lines[y] = string.Join(",", GetRow(grid, y));
            }

            return string.Join(",", lines);
        }

        private string[] GetRow(string[,] grid, int rowNumber)
        {
            // grid.GetLength(0) returns the 1st dimension, so 10 (10x100)
            return Enumerable.Range(0, grid.GetLength(0))
                    .Select(x => grid[x, rowNumber])
                    .ToArray();
        }

        public void Save(int levelNb)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create($"level{levelNb}.xml", settings))
            {
                IntermediateSerializer.Serialize(writer, this, null);
            }
        }

        public static void Load(int levelNb)
        {
            //TODO
        }
    }
}
