using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Lession4
{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 5;

        public float turnSpeed = 20;
        
        private float horizontalInput;

        // Update is called once per frame
        void Update()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

            var angle = Time.deltaTime * turnSpeed * horizontalInput;
            
            transform.Rotate(Vector3.up, angle);
        }
    }
}