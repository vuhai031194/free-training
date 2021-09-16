using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLocalGlobalSpace : MonoBehaviour
{
    public float speed = 20;
    private Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        print($"local position: {transform.localPosition}");
        print($"local position: {transform.position}");
        print(transform.TransformPoint(new Vector3(3, 2, 2)));
        print(transform.InverseTransformDirection(new Vector3(0, 1.61f,0)));
        
        rigidbody.AddTorque(Vector3.up * 100);
        rigidbody.AddForce(Vector3.left);
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        
        rigidbody.AddForce(Vector3.right * horizontalInput * speed);
    }
}
