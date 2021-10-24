using UnityEngine;

namespace Infrastructure.MonoServices.InputHandlers
{
    public class MobileInputHandler : InputHandlerBase
    {
        public void Update()
        {
            CheckInput();
        }

        private void CheckInput()
        {
            if (Input.touchCount > 0)
            {
                InputHandled?.Invoke(Input.GetTouch(0));
            }
        }
    }
}