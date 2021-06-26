using System.Collections.Generic;
using UnityEngine;

namespace FlightPattern {

    [RequireComponent(typeof(Rigidbody))]
    public abstract class BaseFlightPattern : MonoBehaviour, IFlightPatternable
{
        public abstract void IncrementRigidbody(Rigidbody rb, Vector3 startPos, float dt);
}


}