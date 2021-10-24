namespace Infrastructure.Services
{
    public class ServiceContainer
    {
        private static ServiceContainer _instance;

        public static ServiceContainer Container => _instance ??= new ServiceContainer();

        public void RegisterSingle<TService>(TService implementation) where TService : IService =>
            Implementation<TService>.Instance = implementation;

        public TService Single<TService>() where TService : IService =>
            Implementation<TService>.Instance;

        private class Implementation<TService> where TService : IService
        {
            public static TService Instance;
        }
    }
}