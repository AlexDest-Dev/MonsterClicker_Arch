using System;
using System.Collections;
using Infrastructure;
using Infrastructure.Factories;
using Infrastructure.Factories.EnemyFactory;
using Infrastructure.Services;
using Infrastructure.Services.RandomService;
using UnityEngine;
using Utils;
using Utils.ObjectPool;

namespace GameLogic.Enemies
{
    public class EnemySpawner : ISpawner
    {
        private readonly IObjectPool<Enemy> _pool;
        private readonly IRandomService _positionRandomizer;
        private Vector3Bounds2D _bounds;
        private WaitForSeconds _spawnRate;
        private readonly ICoroutineRunner _spawnerRunner;
        private Coroutine _spawnCoroutine;

        public EnemySpawner(IEnemyFactory factory, IRandomService randomService, ICoroutineRunner coroutineRunner)
        {
            _pool = new EnemyObjectPool(factory);
            _positionRandomizer = randomService;
            _spawnerRunner = coroutineRunner;
            _bounds = new Vector3Bounds2D
            {
                LeftDownBound = new Vector3(-10, 0, -10),
                RightUpBound = new Vector3(10, 0, 10)
            };
        }

        public void StartSpawn(float spawnRate)
        {
            _spawnRate = new WaitForSeconds(spawnRate);
            _spawnCoroutine = _spawnerRunner.StartCoroutine(Spawn());
        }

        public void StopSpawn()
        {
            _spawnerRunner.StopCoroutine(_spawnCoroutine);
        }
        private IEnumerator Spawn()
        {
            while (true)
            {
                Enemy newEnemy = _pool.TakeObject();
                Vector3 randomPosition = _positionRandomizer.GetRandomPosition(_bounds);
                newEnemy.transform.position = randomPosition;
                newEnemy.Activate();
                yield return _spawnRate;
            }
        }
    }
}