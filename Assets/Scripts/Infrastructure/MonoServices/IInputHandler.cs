using System;
using UnityEngine;

namespace Infrastructure.MonoServices
{
    public interface IInputHandler
    {
        Action<Touch> InputHandled { get; set; }
    }
}