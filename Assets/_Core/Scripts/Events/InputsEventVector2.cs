using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Events
{
    [CreateAssetMenu(fileName = "new_" + nameof(InputsEventVector2), menuName = "Events/Inputs/Vector 2")]
    public class InputsEventVector2 : ScriptableObject
    {
        public Action<Vector2> Vector2Action;

        public void InvokeEvents(InputAction.CallbackContext _ctx)
        {
            if (_ctx.started)
            {
                Vector2Action?.Invoke(_ctx.ReadValue<Vector2>());
            }
        }
    }
}