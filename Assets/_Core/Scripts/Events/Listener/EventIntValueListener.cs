using UnityEngine;
using UnityEngine.Events;

namespace Events.Listener
{
    public class EventIntValueListener : MonoBehaviour
    {
        [SerializeField] private EventIntValue _eventIntValue;
        [SerializeField] private UnityEvent<int> _callbacks;
    
        private void OnEnable()
        {
            _eventIntValue.IntAction += InvokeEvent;
        }
    
        private void OnDisable()
        {
            _eventIntValue.IntAction -= InvokeEvent;
        }
    
        private void InvokeEvent(int value)
        {
            _callbacks?.Invoke(value);
        }
    }
}