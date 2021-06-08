using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverDebugPrinter : MonoBehaviour
{
    public void PrintGameover(OffscreenGameEventData data)
    {
        Debug.Log("Gameover, " + data.TagString);
    }
}
