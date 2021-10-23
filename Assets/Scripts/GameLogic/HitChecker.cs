using Infrastructure.Services;
using UnityEngine;

namespace GameLogic
{
    public class HitChecker
    {
        private readonly InputService _inputService;

        public HitChecker(InputService inputService)
        {
            _inputService = inputService;
            _inputService.InputHappened += InputHappened;
        }

        private void InputHappened(RaycastHit obj)
        {
            throw new System.NotImplementedException();
        }
    }
}