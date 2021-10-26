using GameLogic.Enemies;
using Infrastructure.Services;
using Utils.ObjectPool;

namespace Infrastructure.Factories
{
    public interface IEnemyFactory : IService
    {
        Enemy CreateEnemy();
    }
}