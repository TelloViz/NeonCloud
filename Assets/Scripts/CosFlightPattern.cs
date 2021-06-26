using UnityEngine;


namespace FlightPattern {

    public class CosFlightPattern : BaseFlightPattern
    {
        [SerializeField] private FlightData fd;

        public override void IncrementRigidbody(Rigidbody rb, Vector3 startPos, float dt) {

            Vector3 newPos;
            newPos.x = rb.position.x + fd.XVelocity * dt;
            newPos.y = startPos.y + fd.Magnitude * Mathf.Cos(rb.position.x / fd.Period);
            newPos.z = rb.position.z;
            rb.position = newPos;
        }

    }
}