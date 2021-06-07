using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateTranslation : MonoBehaviour{
    
    [SerializeField] float x = 1;
    [SerializeField] float y = 1;
    [SerializeField] float z = 1;
    
    void FixedUpdate(){
        transform.Translate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
    }
}
