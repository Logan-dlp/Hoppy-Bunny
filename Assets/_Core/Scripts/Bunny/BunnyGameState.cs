using UnityEngine;
using UnityEngine.Events;

namespace Bunny
{
    public class BunnyGameState : MonoBehaviour
    {
        [SerializeField] private UnityEvent _callbacks;
        
        public void Death()
        {
            Debug.Log("ok");
            _callbacks?.Invoke();
        }
    }
}
