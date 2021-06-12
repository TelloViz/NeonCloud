using UnityEngine;


public class BGResetTarget : MonoBehaviour
{
    [SerializeField] private Transform resetFromTarget;
    [SerializeField] private Transform resetToTarget;

    private void Update()
    {
        if(this.gameObject.transform.position.x <= resetFromTarget.position.x){
            this.gameObject.transform.SetPositionAndRotation(new Vector3(resetToTarget.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z), this.gameObject.transform.rotation);
        }
    }
}
