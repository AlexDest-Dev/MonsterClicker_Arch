using Infrastructure.MonoServices;

namespace Infrastructure.Factories
{
    public interface IMonoServiceFactory
    {
        IInputHandler CreateInputHandler();
    }
}