using UnityEngine;

namespace FlightPattern
{

    [CreateAssetMenu(fileName = "New Flight Pattern Data(FlightData)", menuName = "Flight Pattern/New Flight Pattern Data(FlightData)")]

    class FlightData : ScriptableObject
    {

        [SerializeField] private float xVelocity;
        [SerializeField] private float magnitude;
        [SerializeField] private float period;
    }
}
