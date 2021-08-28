using UnityEngine;

namespace Lession3
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Stats")]
        [Range(-0.1f, 0.1f)]
        public float speed;

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.forward * speed);
        }
    }
}

