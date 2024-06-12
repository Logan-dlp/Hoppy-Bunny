using System;
using UnityEngine;

namespace Events
{
    [CreateAssetMenu(fileName = "new_" + nameof(EventIntValue), menuName = "Events/Primitive/Int")]
    public class EventIntValue : ScriptableObject
    {
        public Action<int> IntAction;

        public void InvokeEvents(int value)
        {
            IntAction?.Invoke(value);
        }
    }
}