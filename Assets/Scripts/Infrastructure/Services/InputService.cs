using System;
using Infrastructure.Factories;
using Infrastructure.MonoServices;
using Infrastructure.MonoServices.InputHandlers;
using UnityEngine;

namespace Infrastructure.Services
{
    public class InputService : IInputService
    {
        private readonly IInputHandler _inputHandler;
        private Camera _camera;

        public InputService(IMonoServiceFactory factory)
        {
            _camera = Camera.main;
            _inputHandler = factory.CreateInputHandler();
            _inputHandler.InputHandled += OnInputHandled;
        }

        private void OnInputHandled(Touch touch)
        {
            Debug.Log("Input handled");
            Ray ray = _camera.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                InputHappened?.Invoke(hit);
            }
        }

        public Action<RaycastHit> InputHappened { get; set; }
    }
}