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
        private readonly ServiceContainer _services;
        private PlayerStats _playerStats;

        public BootstrapState(GameStateMachine stateMachine, ServiceContainer services)
        {
            _stateMachine = stateMachine;
            _services = services;
        }
        public void Enter()
        {
            InitilizePlayerStats();
            RegisterServices();
        }

        private void RegisterServices()
        {
            _services.RegisterSingle<IMonoServiceFactory>(new MonoServiceFactory());
            _services.RegisterSingle<IInputService>(new InputService(_services.Single<IMonoServiceFactory>()));
        }

        private void InitilizePlayerStats()
        {
            _playerStats = new PlayerStats
            {
                Damage = 10,
                EnemyMaxCount = 10
            };
        }

        public void Exit()
        {
            
        }
    }
}