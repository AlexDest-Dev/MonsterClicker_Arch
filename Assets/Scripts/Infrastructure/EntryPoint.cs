namespace Infrastructure
{
    public class EntryPoint
    {
        public readonly GameStateMachine GameStateMachine;

        public EntryPoint()
        {
            GameStateMachine = new GameStateMachine();
        }
    }
}