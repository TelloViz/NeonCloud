using UnityEngine;


internal interface IFlightPatternable {
    void IncrementRigidbody(Rigidbody rb, Vector3 startPos, float dt);
}