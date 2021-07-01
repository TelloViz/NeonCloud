using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SurfPos
{

    [CreateAssetMenu(fileName = "New Surf Position (SurfPosition)", menuName = "Surf Position/New Surf Position (SurfPosition)")]

    public class SurfPosition : ScriptableObject
    {
        [SerializeField] public Vector2 rear;
        [SerializeField] public Vector2 mid;
        [SerializeField] public Vector2 forward;
    }

}