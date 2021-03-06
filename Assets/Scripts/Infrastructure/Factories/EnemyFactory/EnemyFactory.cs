using GameLogic.Enemies;
using Infrastructure.Services.AssetProvider;

namespace Infrastructure.Factories.EnemyFactory
{
    public class EnemyFactory : IEnemyFactory
    {
        private readonly IAssetProvider _assetProvider;

        public EnemyFactory(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }

        public Enemy CreateEnemy()
        {
            Enemy newEnemy = _assetProvider.Instantiate<Enemy>(AssetPaths.EnemyPath);
            EnemyHealth enemyHealth = newEnemy.GetComponent<EnemyHealth>();
            enemyHealth.Init(10);
            return newEnemy;
        }
    }
}