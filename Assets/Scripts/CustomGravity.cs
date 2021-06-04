using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGravity : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 AccelerationVector = new Vector3(0f, 0f, 0f);
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   void FixedUpdate()
   {
       rb.AddForce(AccelerationVector, ForceMode.Acceleration);
   }
}
