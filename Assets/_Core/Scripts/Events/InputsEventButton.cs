using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Events
{
    [CreateAssetMenu(fileName = "new_" + nameof(InputsEventButton), menuName = "Events/Inputs/Button")]
    public class InputsEventButton : ScriptableObject
    {
        public Action ButtonAction;

        public void InvokeEvent(InputAction.CallbackContext ctx)
        {
            if (ctx.started)
            {
                ButtonAction?.Invoke();
            }
        }
        
        public void InvokeEvent()
        {
            ButtonAction?.Invoke();
        }
    }
}