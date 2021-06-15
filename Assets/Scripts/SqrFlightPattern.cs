using UnityEngine;
using System.Collections;

namespace FlightPattern {

    [CreateAssetMenu(fileName = "New Flight Pattern (PlantMonsterFlightPatternSqr)", menuName = "Flight Pattern/New Flight Pattern (PlantMonsterFlightPatternSqr)")]

    public class SqrFlightPattern : PlantMonsterFlightPattern
    {
        [SerializeField] private float xVelocity;
        [SerializeField] private float magnitude;
        [SerializeField] private float period;

        public override void IncrementRigidbody(Rigidbody rb, Vector3 startPos, float dt) {

            Vector3 newPos;
            newPos.x = rb.position.x + xVelocity * dt;
            newPos.y = startPos.y + magnitude * Mathf.Sign(Mathf.Sin((rb.position.x * 2 * Mathf.PI)/ period));
            newPos.z = rb.position.z;
            rb.position = newPos;
        }

    }
}