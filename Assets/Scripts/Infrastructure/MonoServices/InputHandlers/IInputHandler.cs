using System;
using UnityEngine;

namespace Infrastructure.MonoServices.InputHandlers
{
    public interface IInputHandler
    {
        Action<Touch> InputHandled { get; set; }
    }
}