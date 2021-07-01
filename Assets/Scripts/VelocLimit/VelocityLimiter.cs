using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VelocLimit;


namespace VelocLimit
{
    [RequireComponent(typeof(Rigidbody))]

    public class VelocityLimiter : MonoBehaviour
    {

        private float liftVelocityLimit;
        private float gravVelocityLimit;

        private Rigidbody rb;

        public float LiftVelocityLimit { get => liftVelocityLimit; set => liftVelocityLimit = value; }
        public float GravVelocityLimit { get => gravVelocityLimit; set => gravVelocityLimit = value; }



        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 veloc = rb.velocity;
            if (rb.velocity.y > LiftVelocityLimit)
            {
                veloc.y = LiftVelocityLimit;
            }
            if (rb.velocity.y < GravVelocityLimit)
            {
                veloc.y = GravVelocityLimit;
            }

            rb.velocity = veloc;
        }
    }
}