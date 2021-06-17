 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

[RequireComponent(typeof(Rigidbody))]

public class PlayerCharacter : MonoBehaviour{

    private float y_velocity = 0;
    [SerializeField] private Vector3 liftForce;
    [SerializeField] private Vector3 gravForce;
    private Rigidbody rb;

    private bool isLifting;
    private bool hasBegun = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 0);
    }

    public void OnLift(InputAction.CallbackContext context){
        if (context.started == true){
            isLifting = true;
            hasBegun = true;
        }
        else if (context.canceled == true){
            isLifting = false;
        }
    }

    void FixedUpdate(){
        if (isLifting == true)
        {
            rb.AddForce(liftForce);
        }
        else if (isLifting == false)
        {
            if (hasBegun == true)
            {
                rb.AddForce(gravForce);
            }
        }
    }
}