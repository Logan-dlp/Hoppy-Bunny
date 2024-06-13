using UnityEngine;

namespace DynamicEnvironment
{
    public class WoodPlane : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private Transform _unspawnPoint;
        [SerializeField] private float _speed;

        private Vector3 _initialPosition;

        private void Awake()
        {
            _initialPosition = transform.position;
        }

        private void Update()
        {
            transform.position += transform.forward * _speed * Time.deltaTime;

            if (transform.position.x - _unspawnPoint.position.x < .5f)
            {
                transform.position = _initialPosition;
            }
        }
    }
}