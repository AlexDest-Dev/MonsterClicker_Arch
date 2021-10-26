using Infrastructure.Factories;
using Infrastructure.Services;
using Utils.ObjectPool;

namespace GameLogic.Enemies
{
    public class Spawner
    {
        private const int DefaultEnemyInitialization = 10;
        private readonly BaseObjectPool<Enemy> _pool;

        public Spawner(IEnemyFactory factory)
        {
            _pool = new EnemyObjectPool(factory);
        }

        private void Spawn()
        {
            Enemy newEnemy = _pool.TakeObject();
        }
    }
}