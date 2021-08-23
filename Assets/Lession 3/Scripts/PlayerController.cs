using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lession3
{
    public class PlayerController : MonoBehaviour
    {
        public float distancePerSecond;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(0, 0, distancePerSecond * Time.deltaTime);
        }
    }
}

