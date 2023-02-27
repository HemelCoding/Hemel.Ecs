using System;
using Hemel.Ecs.Implementations;

namespace Hemel.Ecs;

public class WorldFactory
{
    public static IWorld Create()
    {
        return new World();
    }
}
