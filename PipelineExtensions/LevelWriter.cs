using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using System;
using System.Collections.Generic;
using System.Text;

using TWrite = PipelineExtensions.Level;

namespace PipelineExtensions
{
    [ContentTypeWriter]
    public class LevelWriter : ContentTypeWriter<TWrite>
    {
        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            throw new NotImplementedException();
        }

        protected override void Write(ContentWriter output, TWrite value)
        {
            throw new NotImplementedException();
        }
    }
}
