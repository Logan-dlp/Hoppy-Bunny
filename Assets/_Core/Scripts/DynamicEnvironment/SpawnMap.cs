using ScriptableObjects;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DynamicEnvironment
{
    public class SpawnMap : MonoBehaviour
    {
        [SerializeField] private GameObjectArray _mapsSources;
        [SerializeField] private float _distance;

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Bunny")
            {
                int random = Random.Range(0, _mapsSources.GameObjectsArray.Length);
                Instantiate(_mapsSources.GameObjectsArray[random], transform.position + transform.forward * _distance, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}