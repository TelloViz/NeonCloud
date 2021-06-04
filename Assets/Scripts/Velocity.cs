using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{

    
    [SerializeField] float x = 1;
    [SerializeField] float y = 1;
    [SerializeField] float z = 1;
    // Start is called before the first frame update
    
    void FixedUpdate()
    {
        /* TODO find out if this Time.deltaTime is needed. I feel delta time shouldn't be needed for a fixed update... 
         ...and am not sure if the deltaTime is referring to the time of a normal update...*/
        transform.Translate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
    }

    void OnTrigger()
    {
    }
}
