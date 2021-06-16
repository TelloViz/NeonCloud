using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BowserFlight : MonoBehaviour
{
    [SerializeField] private FlightPattern.PlantMonsterFlightPattern fp;
    [SerializeField] private Vector3 startPos;
    private Rigidbody rb;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        fp.IncrementRigidbody(rb, startPos, Time.deltaTime);
    }
}
