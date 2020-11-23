using Microsoft.Xna.Framework.Content;

using TRead = PipelineExtensions.Level;

namespace PipelineExtensions
{

    public class LevelReader : ContentTypeReader<TRead>
    {
        protected override TRead Read(ContentReader input, TRead existingInstance)
        {
            return new TRead(input.ReadString());
        }
    }
}
