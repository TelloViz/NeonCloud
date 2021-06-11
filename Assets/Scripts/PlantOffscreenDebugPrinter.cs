using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantOffscreenDebugPrinter : MonoBehaviour
{
    public void PrintPlantOffscreen(OffscreenGameEventData data)
    {
        Debug.Log("Plant Offscreen, " + data.TagString);
    }
}
