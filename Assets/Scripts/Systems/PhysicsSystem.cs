using Entitas;

public class PhysicsSystem : IExecuteSystem
{
    private readonly Contexts _contexts;
    private readonly PhysicsComp _physics;
    
    public PhysicsSystem(Contexts contexts)
    {
        _contexts = contexts;
        _physics = contexts.physics.physicsComp;
    }
    
    public void Execute()
    {
        foreach (var collisionInfo in _physics.CollisionInfos)
        {
            var sourceEntity = _contexts.game.GetEntityWithIdComp(
                collisionInfo.SourceId);   
            var otherEntity = _contexts.game.GetEntityWithIdComp(
                collisionInfo.OtherId);

            if (sourceEntity.isBulletTag)
            {
                if (otherEntity.isEnemyTag)
                {
                    sourceEntity.isDestroyFlag = true;
                    otherEntity.isDestroyFlag = true;
                    
                    EnemyUtil.CreateCoin(otherEntity);
                }
            }
            else if (sourceEntity.isCoinTag)
            {
                if (otherEntity.isPlayerTag)
                {
                    if (!sourceEntity.hasTargetComp)
                        sourceEntity.AddTargetComp(otherEntity.idComp.Value);
                }
            }
        }
        
        _physics.CollisionInfos.Clear();
    }
}
