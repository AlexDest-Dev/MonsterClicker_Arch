using System.Collections.Generic;
using Infrastructure.Factories;
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
            return _factory.CreateEnemy();
        }
    }
}