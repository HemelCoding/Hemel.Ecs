using System;
namespace Hemel.Ecs.Implementations;

internal class World : IWorld
{
    private readonly IDictionary<Guid, Entity> entities = new Dictionary<Guid, Entity>();

    public void AddComponent(Guid entityId, IComponent component)
    {
        entities[entityId].Components.Add(component);
    }

    public Guid CreateEntity()
    {
        var entityId = Guid.NewGuid();

        entities[entityId] = new Entity { Id = entityId };

        return entityId;
    }

    public void DeleteEntity(Guid entityId)
    {
        entities.Remove(entityId);
    }

    public void Execute(ISystem system)
    {
        var filteredEntities = entities.Values.Where(e => system.ComponentTypes.All(t => e.Components.Any(c => c.GetType() == t)));
        var systemEntities = filteredEntities.Select(e => new ResultEntity(e.Id, e.Components.Where(c => system.ComponentTypes.Contains(c.GetType())).ToArray()));

        system.Execute(systemEntities);
    }

    public void RemoveComponent(Guid entityId, IComponent component)
    {
        entities[entityId].Components.Remove(component);
    }
}
