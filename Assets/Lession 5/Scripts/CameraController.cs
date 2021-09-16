using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lession5
{
    public class CameraController : MonoBehaviour
    {
        public GameObject car;

        private Vector3 offsetPosition;
        // Start is called before the first frame update
        private void Start()
        {
            if (car == null)
            {
                //car = GameObject.Find("KartClassic_Player");
                car = GameObject.FindGameObjectWithTag("Player");
                //car = GameObject.FindWithTag("Player");
            }
            offsetPosition = transform.position - car.transform.position;
        }

        private void LateUpdate()
        {
            transform.position = car.transform.position + car.transform.rotation * offsetPosition;
        
            transform.LookAt(car.transform);
        }
    }
}

