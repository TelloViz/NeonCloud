using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Debug
{
    public class PanelOffscreenDebugPrinter : MonoBehaviour
    {
        public void PrintPanelOffscreen(OffscreenGameEventData data)
        {
            Debug.Log("Panel offscreen at " + data.OffScreenLocation);
        }
    }
}