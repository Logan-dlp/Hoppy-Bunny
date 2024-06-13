using Events;
using UnityEngine;

namespace DynamicEnvironment
{
    public class Coin : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out RecoveryItem recoveryItem))
            {
                recoveryItem.AddingCoin(1);
                Destroy(gameObject);
            }
        }
    }
}