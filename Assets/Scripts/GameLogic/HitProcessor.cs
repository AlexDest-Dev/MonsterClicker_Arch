using Data;
using GameLogic.Enemies;
using Infrastructure.Services;
using Infrastructure.Services.InputService;
using UnityEngine;

namespace GameLogic
{
    public class HitProcessor
    {
        private readonly IInputService _inputService;
        private readonly PlayerStats _playerStats;

        public HitProcessor(IInputService inputService, PlayerStats stats)
        {
            _inputService = inputService;
            _inputService.InputHappened += ProcessHit;
            _playerStats = stats;
        }

        private void ProcessHit(RaycastHit hit)
        {
            GameObject hitObject = hit.collider.gameObject;
            if (hitObject.TryGetComponent(out EnemyHealth health))
            {
                ApplyDamage(health);
            }
        }

        private void ApplyDamage(EnemyHealth health)
        {
            health.TakeDamage(_playerStats.Damage);
        }
    }
}