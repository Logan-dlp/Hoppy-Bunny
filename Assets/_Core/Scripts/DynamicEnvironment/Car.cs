using Bunny;
using UnityEngine;

namespace DynamicEnvironment
{
    public class Car : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private Transform _unspawnPoint;
        [SerializeField] private float _speed;

        private void Update()
        {
            transform.position += transform.forward * _speed * Time.deltaTime;

            if (transform.position.x - _unspawnPoint.position.x < .5f)
            {
                transform.position = _spawnPoint.position;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out BunnyGameState bunnyGameState))
            {
                bunnyGameState.Death();
            }
        }
    }
}