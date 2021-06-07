using UnityEngine;
using SOEvents.Events;

public class PlayerOffscreenTrigger : MonoBehaviour{ 
    [SerializeField] private OffscreenGameEvent offScreenEvent;
    private void OnTriggerEnter(Collider other){

        // Raise OffscreenGameEvent when player passes into Player offscreen Trigger zone
        offScreenEvent.Raise(new OffscreenGameEventData(other.gameObject.transform.position, other.gameObject.tag));
    }  
}