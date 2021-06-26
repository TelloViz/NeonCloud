using UnityEngine;
using System.Collections;

namespace FlightPattern {

    
    public class SqrFlightPattern : BaseFlightPattern
    {

        [SerializeField] private FlightData fd;

        public override void IncrementRigidbody(Rigidbody rb, Vector3 startPos, float dt)
        {

            Vector3 newPos;
            newPos.x = rb.position.x + fd.XVelocity * dt;
            newPos.y = startPos.y + fd.Magnitude * Mathf.Sign(Mathf.Sin((rb.position.x * 2 * Mathf.PI)/ fd.Period));
            newPos.z = rb.position.z;
            rb.position = newPos;
        }

    }
}