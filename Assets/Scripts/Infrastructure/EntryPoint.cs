using Infrastructure.Services;

namespace Infrastructure
{
    public class EntryPoint
    {
        public readonly GameStateMachine GameStateMachine;

        public EntryPoint(ICoroutineRunner runner)
        {
            GameStateMachine = new GameStateMachine(ServiceContainer.Container, runner);
        }
    }
}