﻿using Microsoft.Xna.Framework;

namespace Choppers.Engine.Particles.EmitterTypes
{
    public interface IEmitterType
    {
        Vector2 GetParticleDirection();
        Vector2 GetParticlePosition(Vector2 emitterPosition);
    }
}
