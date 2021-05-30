using UnityEngine;

public class EndScript : MonoBehaviour {
    [SerializeField]
    private Vector3 distance = new Vector3(0f, 0f, 0f);

    private void OnTriggerEnter(Collider other) {
        var gameObj = other.gameObject;
        var colorChanger = gameObj.GetComponent<IColorChangeable>();
        if(colorChanger != null) {
            colorChanger.ChangeToRandomColorInRange();
        }
        gameObj.transform.Translate(distance, Space.Self);
    }
}