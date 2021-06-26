using UnityEngine;
using FlightPattern;


[RequireComponent(typeof(Rigidbody), typeof(BaseFlightPattern))]
public class PlantMonster : MonoBehaviour {

    private Rigidbody rb;
    [SerializeField] private Vector3 startingPos;
    
    /* I made fp (BaseFlightPattern a SerializeField in order to allow a 
     * designer to swap these patterns out easily in the editor. I chose
     this approach vs. using GetComponent<BaseFlightPattern> because I thought
    maybe a Plant monster (in this case) would potentially be holding multiple FlightPattern
    scripts. The problem then becomes, how does the code end of things (here in the plant script) 
    know how many are available to choose from. It allows a designer to drag and drop from these assigned 
    to the plant monster but the logic would have to poll for them by name, array index or something? Doesn't seem wise.*/

    // TODO I think I need to make a Flight Handler that calls these various available patterns for you... ask Vast
    [SerializeField] BaseFlightPattern fp;


    private float frameTime;

    #region Mono Behaviour
    void Start() {
        rb = this.GetComponent<Rigidbody>();
        rb.position = startingPos;
    }

    void FixedUpdate() {
       
        if (rb != null && fp != null) {
           fp.IncrementRigidbody(rb, startingPos, Time.deltaTime);
        }
    }
    #endregion
}
