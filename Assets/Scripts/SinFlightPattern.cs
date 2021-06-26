using UnityEngine;
using System.Collections;

namespace FlightPattern {

    public class SinFlightPattern : BaseFlightPattern
    {

        [SerializeField] private FlightData flightData;


        public override void IncrementRigidbody(Rigidbody rb, Vector3 startPos, float dt) {

            Vector3 newPos;
            newPos.x = rb.position.x + flightData.XVelocity * dt;
            newPos.y = startPos.y + flightData.Magnitude * Mathf.Sin(rb.position.x / flightData.Period);
            newPos.z = rb.position.z;

            rb.position = newPos;
        }

    }
}