using SOEvents.Events;
using UnityEngine;

public class PanelOffscreenTrigger : MonoBehaviour
{
    [SerializeField] private OffscreenGameEvent offScreenEvent;
    private void OnTriggerEnter(Collider other){

        // Raise OffscreenGameEvent when BG Panel passes into BG panel offscreen Trigger zone
        offScreenEvent.Raise(new OffscreenGameEventData(other.gameObject.transform.position, other.gameObject.tag));
    }
}
