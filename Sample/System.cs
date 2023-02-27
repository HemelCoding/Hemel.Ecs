using Hemel.Ecs;

namespace Sample;

public class System : ISystem
{
    public IEnumerable<Type> ComponentTypes { get; } = new[] { typeof(Component) };

    public void Execute(IEnumerable<IEntity> entities)
    {
        foreach (var entity in entities)
        {
            entity.GetType();
        }
    }
}