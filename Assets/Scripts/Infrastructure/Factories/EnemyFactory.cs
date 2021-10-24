using GameLogic.Enemies;
using UnityEngine;

namespace Infrastructure.Factories
{
    public class EnemyFactory : IEnemyFactory
    {
        public EnemyFactory()
        {
            
        }

        public Enemy CreateEnemy()
        {
            Enemy enemyPrefab = Resources.Load<Enemy>("Enemies/SimpleEnemy");
            Enemy newEnemy = GameObject.Instantiate(enemyPrefab);
            EnemyHealth enemyHealth = newEnemy.GetComponent<EnemyHealth>();
            enemyHealth.Init(10);
            return newEnemy;
        }
    }
}