using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffscreenGameEventTest : MonoBehaviour
{
    public void Test(OffscreenGameEventData data){
        Debug.Log(data.TagString + " " + data.OffScreenLocation);
    }
}
