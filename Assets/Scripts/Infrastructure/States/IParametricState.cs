namespace Infrastructure.States
{
    public interface IParametricState<TParameter> : IExitableState
    {
        void Enter(TParameter parameter);
    }
}