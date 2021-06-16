using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class VelocityLimiter : MonoBehaviour
{

    [SerializeField] private float maxUpVelocity, maxDownVelocity, maxLeftVelocity, maxRightVelocity;

    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 veloc = rb.velocity;
        if(rb.velocity.x > maxRightVelocity)
        {
            veloc.x = maxRightVelocity;
        }
        if(rb.velocity.x < maxLeftVelocity)
        {
            veloc.x = maxLeftVelocity;
        }
        if (rb.velocity.y > maxUpVelocity)
        {
            veloc.y = maxUpVelocity;
        }
        if (rb.velocity.y < maxDownVelocity)
        {
            veloc.y = maxDownVelocity;
        }

        rb.velocity = veloc;
    }
}
