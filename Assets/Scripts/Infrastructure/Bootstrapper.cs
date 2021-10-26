using Infrastructure.States;
using UnityEngine;

namespace Infrastructure
{
    public class Bootstrapper : MonoBehaviour, ICoroutineRunner
    {
        private EntryPoint _entryPoint;

        private void Start()
        {
            _entryPoint = new EntryPoint(this);
            _entryPoint.GameStateMachine.Enter<BootstrapState>();
        }
    }
}