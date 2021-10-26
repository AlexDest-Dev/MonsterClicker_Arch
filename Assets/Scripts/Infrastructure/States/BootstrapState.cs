using Data;
using GameLogic;
using Infrastructure.Factories;
using Infrastructure.Services;
using Infrastructure.Services.AssetProvider;
using Infrastructure.Services.InputService;
using Infrastructure.Services.RandomService;

namespace Infrastructure.States
{
    public class BootstrapState : IState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly ServiceContainer _services;

        public BootstrapState(GameStateMachine stateMachine, ServiceContainer services)
        {
            _stateMachine = stateMachine;
            _services = services;
        }
        public void Enter()
        {
            RegisterServices();
            _stateMachine.Enter<LoadLevelState>();
        }

        private void RegisterServices()
        {
            _services.RegisterSingle<IAssetProvider>(new AssetProvider());
            _services.RegisterSingle<IMonoServiceFactory>(new MonoServiceFactory());
            _services.RegisterSingle<IInputService>(new InputService(_services.Single<IMonoServiceFactory>()));
            _services.RegisterSingle<IEnemyFactory>(new EnemyFactory(_services.Single<IAssetProvider>()));
            _services.RegisterSingle<IRandomService>(new RandomService());
        }

        public void Exit()
        {
            
        }
    }
}