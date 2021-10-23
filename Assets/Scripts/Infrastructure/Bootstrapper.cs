using Infrastructure.States;
using UnityEngine;

namespace Infrastructure
{
    public class Bootstrapper : MonoBehaviour
    {
        private EntryPoint _entryPoint;

        private void Start()
        {
            _entryPoint = new EntryPoint();
            _entryPoint.GameStateMachine.Enter<BootstrapState>();
        }
    }
}