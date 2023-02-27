namespace Hemel.Ecs;

public interface IWorld
{
    void AddComponent(Guid entityId, IComponent component);
    void RemoveComponent(Guid entityId, IComponent component);

    Guid CreateEntity();
    void DeleteEntity(Guid entityId);

    void Execute(ISystem system);
}
