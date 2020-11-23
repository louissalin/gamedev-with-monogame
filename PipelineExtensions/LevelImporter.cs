using Microsoft.Xna.Framework.Content.Pipeline;
using System.IO;

using TImport = System.String;

namespace PipelineExtensions
{
    [ContentImporter(".txt", DisplayName = "LevelImporter", DefaultProcessor = "LevelProcessor")]
    public class LevelImporter : ContentImporter<TImport>
    {
        public override TImport Import(string filename, ContentImporterContext context)
        {
            return File.ReadAllText(filename);
        }
    }
}
