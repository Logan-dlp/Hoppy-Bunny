using System;
using UnityEngine;

namespace GameCamera
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private float _smoothSpeed = 1;
        [SerializeField] private Vector3 _offset;

        private void Awake()
        {
            transform.position = _target.position + _offset;
            transform.LookAt(_target);
        }

        private void Update()
        {
            Vector3 desiredPosition = _target.position + _offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}