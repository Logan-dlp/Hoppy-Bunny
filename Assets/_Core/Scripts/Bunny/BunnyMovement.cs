using System;
using System.Collections;
using UnityEngine;

namespace Bunny
{
    public class BunnyMovement : MonoBehaviour
    {
        [SerializeField] private float _jumpForce;
        [SerializeField] private LayerMask _obstacleLayer;

        private bool _haveParent = false;

        private void Update()
        {
            Debug.DrawLine(transform.position, transform.position + transform.forward, Color.red);
        }

        public void Movement(Vector2 direction)
        {
            transform.LookAt(new Vector3(direction.x, 0, direction.y) + transform.position);
            Physics.Raycast(transform.position, transform.forward, out RaycastHit raycastHit, _jumpForce);
            if (raycastHit.transform == null || raycastHit.transform.tag != "Block")
            {
                if (_haveParent)
                {
                    Debug.Log(transform.root);
                    transform.SetParent(transform.root);
                    _haveParent = false;
                }
                if (raycastHit.transform != null && raycastHit.transform.tag == "Platform")
                {
                    transform.SetParent(raycastHit.transform);
                    _haveParent = true;
                }
                transform.position = transform.position + transform.forward * _jumpForce;
            }
        }
    }
}
