using UnityEngine;
using FlightPattern;


[RequireComponent(typeof(Rigidbody), typeof(BaseFlightPattern))]
public class PlantMonster : MonoBehaviour {

    private Rigidbody rb;
    [SerializeField] private Vector3 startingPos;
    [SerializeField] BaseFlightPattern fp;


    private float frameTime;

    #region Mono Behaviour
    void Start() {
        rb = this.GetComponent<Rigidbody>();
        rb.position = startingPos;
    }

    void FixedUpdate() {
        frameTime = Time.deltaTime;
        if (rb != null && fp != null)
        {
           fp.IncrementRigidbody(rb, startingPos, frameTime);
        }
    }
    #endregion
}
