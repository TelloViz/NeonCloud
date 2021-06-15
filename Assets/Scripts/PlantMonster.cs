using UnityEngine;
using FlightPattern;


public class PlantMonster : MonoBehaviour, IFlightPatternable {

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
        NextPosition();
    }
    #endregion

    #region Interface Method
    public void NextPosition() {
        if (rb != null) {

            this.flightPattern.IncrementRigidbody(rb, startingPos, frameTime);
        }
    }
    #endregion
}
