using System.Collections.Generic;
using Infrastructure.Factories;
using Infrastructure.Factories.EnemyFactory;
using Utils.ObjectPool;

namespace GameLogic.Enemies
{
    public class EnemyObjectPool : BaseObjectPool<Enemy>
    {
        private readonly IEnemyFactory _factory;

        public EnemyObjectPool(IEnemyFactory factory)
        {
            _factory = factory;
        }

        protected override Enemy AddObject()
        {
            Enemy newEnemy = _factory.CreateEnemy();
            newEnemy.Deactivate();
            return newEnemy;
        }
    }
}