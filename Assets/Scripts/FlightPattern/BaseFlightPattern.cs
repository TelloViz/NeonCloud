using System.Collections.Generic;
using UnityEngine;

namespace FlightPattern {


public abstract class BaseFlightPattern : ScriptableObject
{
        public abstract void IncrementRigidbody(Rigidbody rb, Vector3 startPos, float dt);
}


}