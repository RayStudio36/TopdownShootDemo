public class GameSystems : Feature
{
    public GameSystems(Contexts contexts)
    {
        // 生成玩家
        Add(new PlayerSpawnSystem(contexts));

        // 生成敌人
        Add(new EnemySpawnSystem(contexts));

        // 玩家输入
        Add(new InputSystem(contexts));
        Add(new PlayerInputProcessSystem(contexts));

        Add(new UpdateTimerSystem(contexts));

        // 目标
        Add(new FollowTargetSystem(contexts));

        Add(new FireSystem(contexts));

        Add(new ActionSystem(contexts));

        Add(new AddViewSystem(contexts));

        Add(new LifetimeSystem(contexts));
        Add(new SyncPosSystem(contexts));

        Add(new PhysicsSystem(contexts));

        Add(new CloseDestroySystem(contexts));

        Add(new GameEventSystems(contexts));

        // 清理
        Add(new InputCleanupSystem(contexts));
        Add(new DestroySystem(contexts));
    }
}

public class FixedUpdateGameSystems : Feature
{
    public FixedUpdateGameSystems(Contexts contexts)
    {
        // 移动
        Add(new MoveSystem(contexts));
        Add(new RotationSystem(contexts));
    }
}