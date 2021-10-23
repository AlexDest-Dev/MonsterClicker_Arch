namespace Infrastructure
{
    public interface IExitableState
    {
        void Exit();
    }

    public interface IState : IExitableState
    {
        void Enter();
    }

    public interface IParametricState<TParameter> : IExitableState
    {
        void Enter(TParameter parameter);
    }
}