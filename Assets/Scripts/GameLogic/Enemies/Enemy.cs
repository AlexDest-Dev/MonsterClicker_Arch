using UnityEngine;
using Utils.ObjectPool;

namespace GameLogic.Enemies
{
    [RequireComponent(typeof(EnemyHealth))]
    public class Enemy : MonoBehaviour, IPoolable
    {
        public void Activate()
        {
            gameObject.SetActive(true);
        }

        public void Deactivate()
        {
            gameObject.SetActive(false);
        }

        public bool IsActive()
        {
            return gameObject.activeInHierarchy;
        }
    }
}