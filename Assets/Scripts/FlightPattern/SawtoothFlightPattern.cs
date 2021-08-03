using UnityEngine;
using System.Collections;

namespace FlightPattern {

    public class SawtoothFlightPattern : BaseFlightPattern
    {
        [SerializeField] private FlightData fd;

        public override void IncrementRigidbody(Rigidbody rb, Vector3 startPos, float dt)
        {
            Vector3 newPos;
            newPos.x = rb.position.x + fd.XVelocity * dt;
            newPos.y = startPos.y + fd.Magnitude * 2 * ((rb.position.x / fd.Period) - Mathf.Floor(.5f + (rb.position.x / fd.Period)));
            newPos.z = rb.position.z;
            rb.position = newPos;
        }

    }
}