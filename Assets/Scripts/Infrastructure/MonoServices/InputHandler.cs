using System;
using UnityEngine;

namespace Infrastructure.MonoServices
{
    public class InputHandler : MonoBehaviour, IInputHandler
    {
        public Action<Touch> InputHandled { get; set; }

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