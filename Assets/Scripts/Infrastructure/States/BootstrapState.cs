using System;
using Infrastructure.Factories;
using Infrastructure.Services;
using UnityEngine;

namespace Infrastructure
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
            IMonoServiceFactory monoServiceFactory = new MonoServiceFactory();
            IInputService inputService = new InputService(monoServiceFactory);
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }
    }
}