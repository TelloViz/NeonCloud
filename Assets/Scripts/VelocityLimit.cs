using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VelocLimit
{


    [CreateAssetMenu(fileName = "New Velocity Limit (VelocityLimit)", menuName = "Velocity Limit/New Velocity Limit(VelocityLimit)")]
    public class VelocityLimit : ScriptableObject
    {
        [SerializeField] public Vector3 maxVelocity;
    }

}