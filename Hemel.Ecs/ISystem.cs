namespace Hemel.Ecs;

public interface ISystem
{
    void Execute(IEnumerable<IEntity> entities);
    IEnumerable<Type> ComponentTypes { get; }
}
