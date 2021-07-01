using UnityEngine;
using System.Collections;

namespace FlightPattern {

    [CreateAssetMenu(fileName = "New Flight Pattern (PlantMonsterFlightPatternCos)", menuName = "Flight Pattern/New Flight Pattern (PlantMonsterFlightPatternCos)")]

    public class CosFlightPattern : PlantMonsterFlightPattern
    {
        [SerializeField] private float xVelocity;
        [SerializeField] private float magnitude;
        [SerializeField] private float period;

        public override void IncrementRigidbody(Rigidbody rb, Vector3 startPos, float dt) {

            Vector3 newPos;
            newPos.x = rb.position.x + xVelocity * dt;
            newPos.y = startPos.y + magnitude * Mathf.Cos(rb.position.x / period);
            newPos.z = rb.position.z;
            rb.position = newPos;
        }

    }
}