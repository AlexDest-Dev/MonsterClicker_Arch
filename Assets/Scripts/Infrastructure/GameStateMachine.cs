using System;
using System.Collections.Generic;
using Infrastructure.Services;
using Infrastructure.States;

namespace Infrastructure
{
    public class GameStateMachine
    {
        private IExitableState _currentState;
        private Dictionary<Type, IExitableState> _states;
        public GameStateMachine(ServiceContainer services)
        {
            _states = new Dictionary<Type, IExitableState>
            {
                [typeof(BootstrapState)] = new BootstrapState(this, services),
            };
        }

        public void Enter<TState>() where TState : class, IState
        {
            TState newState = ChangeState<TState>();
            newState.Enter();
        }

        public void Enter<TState, TParameter>(TParameter parameter) where TState : class, IParametricState<TParameter>
        {
            TState newState = ChangeState<TState>();
            newState.Enter(parameter);
        }

        private TState ChangeState<TState>() where TState : class, IExitableState
        {
            _currentState?.Exit();
            TState newState = GetState<TState>();
            _currentState = newState;
            return newState;
        }

        private TState GetState<TState>() where TState : class, IExitableState
        {
            return _states[typeof(TState)] as TState;
        }
    }
}