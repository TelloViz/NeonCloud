using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantOffscreenResponse : MonoBehaviour
{
    [SerializeField] public Vector3 translateVector = new Vector3(0f, 0f, 0f);
    
    // TODO: Add more randomization to the reset of plants, for now, just translate back to start.
    public void resetPlant(OffscreenGameEventData data){
        data.gameObj.transform.Translate(translateVector);
    }
}
