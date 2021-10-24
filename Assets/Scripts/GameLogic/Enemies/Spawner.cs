using Infrastructure.Factories;
using Infrastructure.Services;
using Utils.ObjectPool;

namespace GameLogic.Enemies
{
    public class Spawner
    {
        private const int DefaultEnemyInitialization = 10;
        private readonly IEnemyFactory _enemyFactory;
        private readonly ObjectPool<Enemy> _pool;

        public Spawner(IEnemyFactory factory, IAssetProvider assetProvider)
        {
            _enemyFactory = factory;
            _pool = new ObjectPool<Enemy>(assetProvider.LoadPrefab<Enemy>(AssetPaths.EnemyPath));
        }

        private void Spawn()
        {
            
        }
    }
}