using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;

using TWrite = PipelineExtensions.Level;

namespace PipelineExtensions
{
    [ContentTypeWriter]
    public class LevelWriter : ContentTypeWriter<TWrite>
    {
        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return "PipelineExtensions.LevelReader, PipelineExtensions";
        }

        protected override void Write(ContentWriter output, TWrite value)
        {
            output.Write(value.LevelStringEncoding);
        }
    }
}
