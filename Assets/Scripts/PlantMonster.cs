using UnityEngine;


public class PlantMonster : MonoBehaviour, IFlightPatternable {

    private Rigidbody rb;

    #region Mono Behaviour
    void Start() {
        rb = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        NextPosition();
    }
    #endregion

    #region Interface Method
    public void NextPosition() {

        
    }
    #endregion
}
