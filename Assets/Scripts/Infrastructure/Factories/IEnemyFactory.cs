using GameLogic.Enemies;
using Utils.ObjectPool;

namespace Infrastructure.Factories
{
    public interface IEnemyFactory
    {
        Enemy CreateEnemy();
    }
}