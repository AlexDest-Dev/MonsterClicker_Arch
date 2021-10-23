namespace Infrastructure.Services
{
    public class ServiceContainer
    {
        private static ServiceContainer _instance;

        public static ServiceContainer Container => _instance ??= new ServiceContainer();

        public static void RegisterSingle<TService>(TService implementation) where TService : IService =>
            Implementation<TService>.Instance = implementation;

        public static TService Single<TService>() where TService : IService =>
            Implementation<TService>.Instance;

        private class Implementation<TService>
        {
            public static TService Instance;
        }
    }
}