using UnityEngine;

// TODO: Ask vast if this should just return the next position, which would make it useable in more cases,
// or have it actually move a rigid body for the gameObject

[RequireComponent(typeof(Rigidbody))]

public class SineFlightPattern : MonoBehaviour, IFlightPatternable {
    
    [SerializeField] private float magnitude;
    [SerializeField] private float period;

    private Rigidbody rb;

    void Awake() {
        rb = this.GetComponent<Rigidbody>();
    }

    #region Class Methods
    public Vector3 NextPosition(float dt) {
        float x =  + rb.velocity.x * dt;
        float y = magnitude * Mathf.Sin(x / period);
        return new Vector3(x, y, rb.position.z);
    }
    #endregion
}
