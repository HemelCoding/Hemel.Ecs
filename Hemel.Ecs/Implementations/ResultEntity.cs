namespace Hemel.Ecs.Implementations;

internal record ResultEntity(Guid Id, IEnumerable<IComponent> Components) : IEntity;
