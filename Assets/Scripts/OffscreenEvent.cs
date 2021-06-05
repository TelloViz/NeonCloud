using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SOEvents.Events;

public class OffscreenEvent : MonoBehaviour
{
    [SerializeField] private OffscreenGameEvent offScreenEvent;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            offScreenEvent.Raise(new OffscreenGameEventData());
        }
    }
}