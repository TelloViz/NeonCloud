using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantMonster : MonoBehaviour{

    [SerializeField] private Vector2 velocity;
    [SerializeField] private Vector3 startingPos;

    private Rigidbody rb;
    
    void Start(){
        this.gameObject.transform.position = startingPos;
        rb = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        updatePosition(rb, velocity);        
    }

    private void updatePosition(Rigidbody rb, Vector3 veloc){
        if (rb != null){
            rb.velocity = velocity * Time.deltaTime;
        }
    }
}
