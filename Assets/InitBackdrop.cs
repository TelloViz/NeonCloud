using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InitBackdrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var objectToColor = GetComponent<ColorManager>();
        objectToColor.ChangeToRandomColorInRange();
    }
}
