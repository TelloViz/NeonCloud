using UnityEngine;
using System.Collections;

namespace FlightPattern {

    [CreateAssetMenu(fileName = "New Flight Pattern (PlantMonsterFlightPatternSin)", menuName = "Flight Pattern/New Flight Pattern (PlantMonsterFlightPatternSin)")]

    public class SinFlightPattern : PlantMonsterFlightPattern
    {
        


        public override void IncrementRigidbody(Rigidbody rb, Vector3 sinData, float dt) {
            float magnitude = sinData.y;
            float period = sinData.z;
            Vector3 mov = new Vector3(rb.position.x + sinData.x * dt, magnitude * Mathf.Sin(rb.position.x / period) * dt, rb.position.z);
            rb.position = mov;

        }

    }
    

}