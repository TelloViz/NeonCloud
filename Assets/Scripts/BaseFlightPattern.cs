using System.Collections.Generic;
using UnityEngine;

namespace FlightPattern {


public abstract class BaseFlightPattern : MonoBehaviour
{
        public abstract void IncrementRigidbody(FlightData fd, Rigidbody rb, float dt);
}


}