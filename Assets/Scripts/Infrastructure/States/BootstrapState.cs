using Data;
using GameLogic;
using Infrastructure.Factories;
using Infrastructure.Services;
using Infrastructure.Services.InputService;

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
            _services.RegisterSingle<IMonoServiceFactory>(new MonoServiceFactory());
            _services.RegisterSingle<IInputService>(new InputService(_services.Single<IMonoServiceFactory>()));
        }

        public void Exit()
        {
            
        }
    }
}