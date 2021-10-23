using Infrastructure.MonoServices;
using UnityEngine;

namespace Infrastructure.Factories
{
    public class MonoServiceFactory : IMonoServiceFactory
    {
        private const string InputHandler = "MonoServices/MouseInputHandler";

        public IInputHandler CreateInputHandler()
        {
            InputHandler handler = Resources.Load<InputHandler>(InputHandler);
            return GameObject.Instantiate(handler);
        }
    }
}