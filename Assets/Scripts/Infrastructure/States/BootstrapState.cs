using System;
using Data;
using GameLogic;
using Infrastructure.Factories;
using Infrastructure.Services;

namespace Infrastructure.States
{
    public class BootstrapState : IState
    {
        private readonly GameStateMachine _stateMachine;

        public BootstrapState(GameStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }
        public void Enter()
        {
            ServiceContainer.RegisterSingle(new MonoServiceFactory());
            ServiceContainer.RegisterSingle(new InputService(ServiceContainer.Single<IMonoServiceFactory>()));
            HitProcessor hitProcessor = new HitProcessor(ServiceContainer.Single<IInputService>(), new PlayerStats());
        }

        public void Exit()
        {
            
        }
    }
}