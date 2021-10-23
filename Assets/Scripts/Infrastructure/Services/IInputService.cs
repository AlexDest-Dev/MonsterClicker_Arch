using System;
using UnityEngine;

namespace Infrastructure.Services
{
    public interface IInputService : IService
    {
        Action<RaycastHit> InputHappened { get; set; }
    }
}