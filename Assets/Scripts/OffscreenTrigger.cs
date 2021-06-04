using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffscreenTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    private bool isOffscreen = false;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player off screen");
    }
}
