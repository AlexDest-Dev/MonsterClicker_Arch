using System;
using UnityEngine;

namespace GameLogic.Enemies
{
    public class EnemyHealth : MonoBehaviour
    {
        public Action<int> ChangedHealth;
        public Action DieHappened;
        
        private int _currentHealth;
        private int _maxHealth;

        public void Init(int maxHealth)
        {
            _maxHealth = maxHealth;
            _currentHealth = maxHealth;
        }

        public void TakeDamage(int value)
        {
            _currentHealth = Mathf.Max(0, _currentHealth - value);
            CheckDeath();
            ChangedHealth?.Invoke(_currentHealth);
        }

        private void CheckDeath()
        {
            if (_currentHealth <= 0)
                DieHappened?.Invoke();
        }
    }
}