using UnityEngine;
using System.Collections;

namespace FlightPattern {

    [CreateAssetMenu(fileName = "New Flight Pattern (PlantMonsterFlightPatternSwth)", menuName = "Flight Pattern/New Flight Pattern (PlantMonsterFlightPatternSwth)")]

    public class SawtoothFlightPattern : PlantMonsterFlightPattern
    {
        [SerializeField] private float xVelocity;
        [SerializeField] private float magnitude;
        [SerializeField] private float period;

        public override void IncrementRigidbody(Rigidbody rb, Vector3 startPos, float dt) {

            Vector3 newPos;
            newPos.x = rb.position.x + xVelocity * dt;
            newPos.y = startPos.y + magnitude * 2 * ((rb.position.x / period) - Mathf.Floor(.5f + (rb.position.x / period)));
            newPos.z = rb.position.z;
            rb.position = newPos;
        }

    }
}