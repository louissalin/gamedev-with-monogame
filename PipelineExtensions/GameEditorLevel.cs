using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Intermediate;
using System.Xml;

namespace PipelineExtensions
{
    public class GameEditorLevel
    {
        public const int LEVEL_LENGTH = 100;
        public const int LEVEL_WIDTH = 10;

        public string[,] GroundGrid { get; set; }
        public string[,] BuildingGrid { get; set; }
        public string[,] ObjectGrid { get; set; }


        public GameEditorLevel()
        {
            GroundGrid = new string[LEVEL_WIDTH, LEVEL_LENGTH];
            BuildingGrid = new string[LEVEL_WIDTH, LEVEL_LENGTH];
            ObjectGrid = new string[LEVEL_WIDTH, LEVEL_LENGTH];
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
