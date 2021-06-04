 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class PlayerScript : MonoBehaviour{
    private float y_velocity = 0;
    [SerializeField] private float lift_velocity = 0f;
    [SerializeField] private float grav_velocity = 0f;


    public void OnLift(InputAction.CallbackContext context){
        if (context.started == true)
        {
            y_velocity = lift_velocity;
        }
        else if (context.canceled == true)
        {
            y_velocity = grav_velocity;
        }
    }

    void FixedUpdate(){
        this.transform.Translate(0, y_velocity * Time.deltaTime, 0);
    }
}