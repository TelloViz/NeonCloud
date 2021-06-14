using UnityEngine;
using System.Collections;

namespace FlightPattern {

    [CreateAssetMenu(fileName = "New Flight Pattern (PlantMonsterFlightPatternSin)", menuName = "Flight Pattern/New Flight Pattern (PlantMonsterFlightPatternSin)")]

    public class SinFlightPattern : PlantMonsterFlightPattern
    {
        


        public override void IncrementRigidbody(Rigidbody rb, Vector3 sinData, Vector3 startPos, float dt) {
            float magnitude = sinData.y;
            float period = sinData.z;
            Vector3 mov = new Vector3(rb.position.x + sinData.x * dt,startPos.y + magnitude * Mathf.Sin(rb.position.x / period), rb.position.z);
            rb.position = mov;

        }

    }
    

}