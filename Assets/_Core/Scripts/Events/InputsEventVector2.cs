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

        public void InvokeEvents(InputAction.CallbackContext ctx)
        {
            if (ctx.started)
            {
                Vector2Action?.Invoke(ctx.ReadValue<Vector2>());
            }
        }
    }
}