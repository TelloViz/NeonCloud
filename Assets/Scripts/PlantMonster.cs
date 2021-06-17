using UnityEngine;
using FlightPattern;


public class PlantMonster : MonoBehaviour {

    private Rigidbody rb;

    [SerializeField] private Vector3 startingPos;

    private Vector3 velocity;

    [SerializeField] private PlantMonsterFlightPattern flightPattern;

    private float frameTime;

    #region Mono Behaviour
    void Start() {
        rb = this.GetComponent<Rigidbody>();
        rb.position = startingPos;
    }

    void FixedUpdate() {
        frameTime = Time.deltaTime;
        if (rb != null)
        {
            flightPattern.IncrementRigidbody(rb, startingPos, frameTime);
        }
    }
    #endregion
}
