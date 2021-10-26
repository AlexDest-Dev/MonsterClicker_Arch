using Data;
using GameLogic;
using GameLogic.Enemies;
using Infrastructure.Factories;
using Infrastructure.Services;
using Infrastructure.Services.InputService;

namespace Infrastructure.States
{
    public class GameLoopState : IState
    {
        private readonly ServiceContainer _serviceContainer;
        private HitProcessor _hitProcessor;
        private EnemySpawner _spawner;
        private ICoroutineRunner _coroutineRunner;

        public GameLoopState(ServiceContainer serviceContainer, ICoroutineRunner runner)
        {
            _serviceContainer = serviceContainer;
            _coroutineRunner = runner;
        }
        public void Enter()
        {
            _hitProcessor = new HitProcessor(_serviceContainer.Single<IInputService>(), new PlayerStats());
            _spawner = new EnemySpawner(_serviceContainer.Single<IEnemyFactory>(), _serviceContainer.Single<IRandomService>(), _coroutineRunner);
            _spawner.StartSpawn(1f);
        }

        public void Exit()
        {
            _spawner.StopSpawn();
        }
    }
}