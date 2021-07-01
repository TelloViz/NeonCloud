using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tello.Debug
{
    public class PanelOffscreenDebugPrinter : MonoBehaviour
    {
        public void PrintPanelOffscreen(OffscreenGameEventData data)
        {
            UnityEngine.Debug.Log("Panel offscreen at " + data.OffScreenLocation);
        }
    }
}