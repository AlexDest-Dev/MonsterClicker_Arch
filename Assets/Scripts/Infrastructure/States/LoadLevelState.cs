using System;

namespace Infrastructure.States
{
    public class LoadLevelState : IState
    {
        private readonly GameStateMachine _stateMachine;

        public LoadLevelState(GameStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }
        public void Enter()
        {
            _stateMachine.Enter<GameLoopState>();
        }

        public void Exit()
        {
            
        }
    }
}