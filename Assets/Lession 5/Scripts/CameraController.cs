using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lession5
{
    public class CameraController : MonoBehaviour
    {
        public GameObject car;

        private Vector3 carCameraVector;
        // Start is called before the first frame update
        private void Start()
        {
            if (car == null)
            {
                //car = GameObject.Find("KartClassic_Player");
                car = GameObject.FindGameObjectWithTag("Player");
                //car = GameObject.FindWithTag("Player");
            }
            carCameraVector = car.transform.position - transform.position;
        }
    }
}

