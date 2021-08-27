using UnityEngine;

namespace Lession4
{
    public class HelloWorld : MonoBehaviour
    {
        private void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            //Get the value of the Horizontal input axis.

            float verticalInput = Input.GetAxis("Vertical");
            //Get the value of the Vertical input axis.
            
            print($"horizontal: {horizontalInput}, vertical: {verticalInput}");
        }
    }
}

