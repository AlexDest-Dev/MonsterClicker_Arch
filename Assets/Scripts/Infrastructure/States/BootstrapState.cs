using System;

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
            
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }
    }
}