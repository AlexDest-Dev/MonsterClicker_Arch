using UnityEngine;

namespace Infrastructure.MonoServices.InputHandlers
{
    public class MouseInputHandler : InputHandlerBase
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Mouse down");
                Touch newTouch = new Touch();
                newTouch.position = Input.mousePosition;
                InputHandled?.Invoke(newTouch);
            }
        }
    }
}