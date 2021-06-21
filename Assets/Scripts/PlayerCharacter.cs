 
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]

public class PlayerCharacter : MonoBehaviour{

    private float y_velocity = 0;
    [SerializeField] private Vector3 liftForce;
    [SerializeField] private Vector3 gravForce;
    private Rigidbody rb;

    [SerializeField] private Sprite sprite1;
    [SerializeField] private Sprite sprite2;

    private SpriteRenderer spriteRend;

    private bool isLifting;
    private bool hasBegun = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 0);

        spriteRend = GetComponent<SpriteRenderer>();
        spriteRend.sprite = sprite1;
    }

    public void OnLift(InputAction.CallbackContext context){
        if (context.started == true){
            isLifting = true;
            hasBegun = true;
        }
        else if (context.canceled == true){
            isLifting = false;
        }
    }

    public void OnGlide(InputAction.CallbackContext context)
    {

    }

    void FixedUpdate(){
        if (isLifting == true)
        {
            rb.AddForce(liftForce);
        }
        else if (isLifting == false)
        {
            if (hasBegun == true)
            {
                rb.AddForce(gravForce);
            }
        }

        if(rb.velocity .y > 0)
        {
            spriteRend.sprite = sprite1;
        }
        else
        {
            spriteRend.sprite = sprite2;
        }
    }
}