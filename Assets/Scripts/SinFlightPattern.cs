using UnityEngine;
using System.Collections;

namespace FlightPattern {


    public class SinFlightPattern : BaseFlightPattern
    {
        [SerializeField] private FlightData fd;

        public override void IncrementRigidbody(FlightData fd) {

            Vector3 newPos;
            newPos.x = fd.rb.position.x + xVelocity * dt;
            newPos.y = startPos.y + magnitude * Mathf.Sin(rb.position.x / period);
            newPos.z = rb.position.z;

            rb.position = newPos;
        }

    }
}