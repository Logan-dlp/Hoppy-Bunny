using System;
using UnityEngine;
using UnityEngine.Events;

namespace Events.Listener
{
    public class InputsEventButtonListener : MonoBehaviour
    {
        [SerializeField] private InputsEventButton _inputsEventButton;
        [SerializeField] private UnityEvent _callbacks;

        private void OnEnable()
        {
            _inputsEventButton.ButtonAction += InvokeEvent;
        }

        private void OnDisable()
        {
            _inputsEventButton.ButtonAction -= InvokeEvent;
        }

        private void InvokeEvent()
        {
            _callbacks?.Invoke();
            Debug.Log("switch");
        }
    }
}