
using UnityEngine;

namespace VelocLimit
{


    [CreateAssetMenu(fileName = "New Angle Limit (AngleLimit)", menuName = "Angle Limit/New Angle Limit(AngleLimit)")]
    public class AngleLimit : ScriptableObject
    {
        [Range(-90f, 90f)]
        [SerializeField] public float maxAngle;
    }

}