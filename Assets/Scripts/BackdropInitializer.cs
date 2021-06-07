using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BackdropInitializer : MonoBehaviour{
    void Start() {
        var objectToColor = GetComponent<ColorManager>();
        if (objectToColor != null) {
            objectToColor.ChangeToRandomColorInRange();
        }
        
    }
}
