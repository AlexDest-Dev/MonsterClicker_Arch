using GameLogic.Enemies;
using Infrastructure.Services;

namespace Infrastructure.Factories.EnemyFactory
{
    public interface IEnemyFactory : IService
    {
        Enemy CreateEnemy();
    }
}