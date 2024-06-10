using System;
using System.Collections;
using UnityEngine;

namespace Bunny
{
    public class BunnyMovement : MonoBehaviour
    {
        [SerializeField] private float _jumpForce;

        public void Movement(Vector2 direction)
        {
            transform.LookAt(new Vector3(direction.x, 0, direction.y) + transform.position);
            transform.position = transform.position + transform.forward * _jumpForce;
        }
    }
}
