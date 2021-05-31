using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    
    [SerializeField] float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }

    void OnTrigger()
    {
        Debug.Log("Collision");
    }
}
