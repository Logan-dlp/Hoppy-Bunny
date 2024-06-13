using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new_" + nameof(GameObjectArray), menuName = "Scriptable Object/GameObject Array")]
    public class GameObjectArray : ScriptableObject
    {
        public GameObject[] GameObjectsArray;
    }
}