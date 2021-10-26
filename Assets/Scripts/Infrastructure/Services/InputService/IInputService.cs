using System;
using UnityEngine;

namespace Infrastructure.Services.InputService
{
    public interface IInputService : IService
    {
        Action<RaycastHit> InputHappened { get; set; }
    }
}