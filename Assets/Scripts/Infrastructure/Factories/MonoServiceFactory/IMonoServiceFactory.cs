using Infrastructure.MonoServices.InputHandlers;
using Infrastructure.Services;

namespace Infrastructure.Factories.MonoServiceFactory
{
    public interface IMonoServiceFactory : IService
    {
        IInputHandler CreateInputHandler();
    }
}