using System;
using UnityEngine;
using UnityEngine.Events;

namespace Events.Listener
{
    public class InputsEventVector2Listener : MonoBehaviour
    {
        [SerializeField] private InputsEventVector2 _inputsEventVector2;
        [SerializeField] private UnityEvent<Vector2> _callbacks;
    
        private void OnEnable()
        {
            _inputsEventVector2.Vector2Action += InvokeEvent;
        }
    
        private void OnDisable()
        {
            _inputsEventVector2.Vector2Action -= InvokeEvent;
        }
    
        private void InvokeEvent(Vector2 vector2)
        {
            _callbacks?.Invoke(vector2);
        }
    }
}