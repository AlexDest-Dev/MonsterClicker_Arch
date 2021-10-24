using Infrastructure.MonoServices;
using Infrastructure.MonoServices.InputHandlers;
using Infrastructure.Services;

namespace Infrastructure.Factories
{
    public interface IMonoServiceFactory : IService
    {
        IInputHandler CreateInputHandler();
    }
}