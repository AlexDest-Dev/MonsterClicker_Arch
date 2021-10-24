using System;
using UnityEngine;

namespace Infrastructure.MonoServices.InputHandlers
{
    public class InputHandlerBase : MonoBehaviour, IInputHandler
    {
        public Action<Touch> InputHandled { get; set; }
    }
}