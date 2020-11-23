using Microsoft.Xna.Framework.Content.Pipeline;

using TInput = System.String;
using TOutput = PipelineExtensions.Level;

namespace PipelineExtensions
{
    [ContentProcessor(DisplayName = "LevelProcessor")]
    public class LevelProcessor : ContentProcessor<TInput, TOutput>
    {
        public override TOutput Process(TInput input, ContentProcessorContext context)
        {
            return new Level(input);
        }
    }
}
