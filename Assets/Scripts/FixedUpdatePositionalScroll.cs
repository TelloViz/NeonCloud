using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdatePositionalScroll : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;
    private Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
    }
    private void FixedUpdate()
    {
        trans.position += velocity * Time.deltaTime;
    }
}
