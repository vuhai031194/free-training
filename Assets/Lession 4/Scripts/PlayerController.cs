using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Lession4
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody rigidbody;

        public float speed = 5;

        public float turnSpeed = 20;

        private float verticalInput;

        private void Awake()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            verticalInput = Input.GetAxis("Vertical");
            rigidbody.AddForce(Vector3.forward * speed * verticalInput * Time.time);
        }
    }
}