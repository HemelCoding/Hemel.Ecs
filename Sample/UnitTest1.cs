using Hemel.Ecs;

namespace Sample;

public class UnitTest1
{
    [Fact]
    public void Sample()
    {
        var factory = new WorldFactory();
        var world = WorldFactory.Create();
        var entityId = world.CreateEntity();
        world.AddComponent(entityId, new Component());
        world.Execute(new System());
    }
}
