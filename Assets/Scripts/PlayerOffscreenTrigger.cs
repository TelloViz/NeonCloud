using UnityEngine;
using SOEvents.Events;

public class PlayerOffscreenTrigger : MonoBehaviour{ 
    [SerializeField] private OffscreenGameEvent offScreenEvent;
    private void OnTriggerEnter(Collider other){

        // Raise OffscreenGameEvent when player passes into Player offscreen Trigger zone
        // TODO: I think I'm going to just have this pass the game object. Make sure remove it or the extra params after you decide.
        offScreenEvent.Raise(new OffscreenGameEventData(other.gameObject.transform.position, other.gameObject.tag, other.gameObject));
    }  
}