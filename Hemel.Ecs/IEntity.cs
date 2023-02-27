namespace Hemel.Ecs;
public interface IEntity
{
    Guid Id { get; }
    IEnumerable<IComponent> Components { get; }
}
