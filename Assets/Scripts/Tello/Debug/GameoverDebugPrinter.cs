using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tello.Debug
{
    public class GameoverDebugPrinter : MonoBehaviour
    {
        public void PrintGameover(OffscreenGameEventData data)
        {
            UnityEngine.Debug.Log("Gameover, " + data.TagString);
        }
    }

}