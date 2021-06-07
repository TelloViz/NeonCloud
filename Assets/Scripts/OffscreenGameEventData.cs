using UnityEngine;

public class OffscreenGameEventData {

    public Vector3 OffScreenLocation { get; private set; }
    public string TagString { get; private set; }
    public OffscreenGameEventData(Vector3 vec3, string tagStr){
        OffScreenLocation = vec3;
        TagString = tagStr;
    }
    
}