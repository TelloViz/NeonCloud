using UnityEngine;
using System.Collections;

namespace FlightPattern {

    [CreateAssetMenu(fileName = "New Flight Pattern (PlantMonsterFlightPatternSin)", menuName = "Flight Pattern/New Flight Pattern (PlantMonsterFlightPatternSin)")]

    public class SinFlightPattern : PlantMonsterFlightPattern
    {
        [SerializeField] private float xVelocity;
        [SerializeField] private float magnitude;
        [SerializeField] private float period;

        // TODO: Figure out a different way to get the sinData to this object, currently it's being passed in and this makes no sense actually
        public override void IncrementRigidbody(Rigidbody rb, Vector3 startPos, float dt) {
            Vector3 mov = new Vector3(rb.position.x + xVelocity * dt,startPos.y + magnitude * Mathf.Sin(rb.position.x / period), rb.position.z);
            rb.position = mov;

        }

    }
}