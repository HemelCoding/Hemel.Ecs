namespace Hemel.Ecs.Implementations;

internal class Entity
{
    public Guid Id { get; set; }

    public List<IComponent> Components { get; } = new();
}
