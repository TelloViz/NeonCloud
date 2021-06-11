using UnityEngine;

public class OffscreenGameEventData {

    public Vector3 OffScreenLocation { get; private set; }
    public string TagString { get; private set; }

    public GameObject gameObj { get; private set; }

    // TODO come back to this because if I end up actually using GameObject in this ctor then I wont need those other two params
    public OffscreenGameEventData(Vector3 vec3, string tagStr, GameObject obj){
        OffScreenLocation = vec3;
        TagString = tagStr;
        gameObj = obj;
    }
    
}