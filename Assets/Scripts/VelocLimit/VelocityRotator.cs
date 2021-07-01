using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VelocLimit
{

    [RequireComponent(typeof(Rigidbody))]

    public class VelocityRotator : MonoBehaviour
    {
        [Range(0f, 90f)]
        [SerializeField] private float maxUpAngle;

        [Range(0f, 90f)]
        [SerializeField] private float maxDownAngle;

        [SerializeField] private float maxUpVeloc;

        [SerializeField] private float maxDownVeloc;

        private Rigidbody rb;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();


        }

        void FixedUpdate()
        {
            if (rb.velocity.y > 0)
            {
                rb.MoveRotation(Quaternion.Euler(0f, 0f, (maxUpAngle * rb.velocity.y) / maxUpVeloc));
            }
            else if (rb.velocity.y < 0)
            {
                rb.MoveRotation(Quaternion.Euler(0f, 0f, ((-maxDownAngle) * rb.velocity.y) / maxDownVeloc));
            }
        }

    }
}