using System;
using UnityEngine;

namespace Lession5
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody rigidbody;

        public float speed = 5;

        public float turnSpeed = 20;
        
        private float horizontalInput;

        private float verticalInput;

        private void Awake()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            horizontalInput = Input.GetAxis("Horizontal");

            verticalInput = Input.GetAxis("Vertical");

            var force = Vector3.forward * Time.deltaTime * speed * verticalInput;
            
            print(force);
            
            rigidbody.AddForce(force);

            var angle = Time.deltaTime * turnSpeed * horizontalInput;
            
            transform.Rotate(Vector3.up, angle);
        }
    }
}