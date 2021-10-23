using Infrastructure.MonoServices;
using UnityEngine;

namespace Infrastructure.Factories
{
    public class MonoServiceFactory : IMonoServiceFactory
    {
        private const string MouseInputHandler = "MonoServices/MouseInputHandler";
        private const string MobileInputHandler = "MonoServices/MobileInputHandler";

        public IInputHandler CreateInputHandler()
        {
            string currentHandler = ChooseHandler();
            InputHandler handler = Resources.Load<InputHandler>(currentHandler);
            return GameObject.Instantiate(handler);
        }

        private string ChooseHandler()
        {
            string currentHandler;
            if (Application.isEditor)
                currentHandler = MouseInputHandler;
            else
                currentHandler = MobileInputHandler;
            return currentHandler;
        }
    }
}