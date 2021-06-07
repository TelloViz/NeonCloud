using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SOEvents.Events;

public class OffscreenEvent : MonoBehaviour{ 
    [SerializeField] private OffscreenGameEvent offScreenEvent;
    private void OnTriggerEnter(Collider other){

        offScreenEvent.Raise(new OffscreenGameEventData(other.gameObject.transform.position, other.gameObject.tag));
    }  
}