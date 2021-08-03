using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tello.Debug
{
    public class PlantOffscreenDebugPrinter : MonoBehaviour
    {
        public void PrintPlantOffscreen(OffscreenGameEventData data)
        {
            UnityEngine.Debug.Log("Plant Offscreen, " + data.TagString);
        }
    }
}