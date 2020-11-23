using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Text;

using TRead = PipelineExtensions.Level;

namespace PipelineExtensions
{

    public class LevelReader : ContentTypeReader<TRead>
    {
        protected override TRead Read(ContentReader input, TRead existingInstance)
        {
            throw new NotImplementedException();
        }
    }
}
