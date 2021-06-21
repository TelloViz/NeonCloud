 
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]

public class PlayerCharacter : MonoBehaviour{

    [SerializeField] private Vector3 liftForce;
    [SerializeField] private Vector3 gravForce;
    private Rigidbody rb;

    [SerializeField] private Sprite surferSprite1;
    [SerializeField] private Sprite surferSprite2;



    

    private enum SurfPositionEnum
    {
        Rear,
        Mid,
        Forward
    };
    [SerializeField] private SurfPositionEnum startingSurfPosition;
    private SurfPositionEnum currentSurfPos;

    [SerializeField] private SurfPos.SurfPosition surfPosCoords;

    private SpriteRenderer spriteRend;

    private bool isLifting;
    private bool isGliding;
    private bool hasBegun = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 0);

        currentSurfPos = startingSurfPosition;

        spriteRend = GetComponent<SpriteRenderer>();
        spriteRend.sprite = surferSprite1;


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
        if (context.started == true)
        {
            isGliding = true;
        }
        else if (context.canceled == true)
        {
            isGliding = false;
        }
    }

    public void OnShiftLeft(InputAction.CallbackContext context)
    {
        switch (currentSurfPos)
        {
            case SurfPositionEnum.Rear:
                break;
            case SurfPositionEnum.Mid:
                currentSurfPos = SurfPositionEnum.Rear;
                break;
            case SurfPositionEnum.Forward:
                currentSurfPos = SurfPositionEnum.Mid;
                break;
            default:
                break;
        }
    }

    public void OnShiftRight(InputAction.CallbackContext context)
    {
        switch (currentSurfPos)
        {
            case SurfPositionEnum.Rear:
                currentSurfPos = SurfPositionEnum.Mid;
                break;
            case SurfPositionEnum.Mid:
                currentSurfPos = SurfPositionEnum.Forward;
                break;
            case SurfPositionEnum.Forward:
                break;
            default:
                break;
        }
    }
    void FixedUpdate(){

        if (isGliding == true)
        {
            rb.velocity = Vector3.zero;
        }
        else if (isLifting == true)
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
            spriteRend.sprite = surferSprite1;
        }
        else
        {
            spriteRend.sprite = surferSprite2;
        }

        //switch (currentSurfPos)
        //{
        //    case SurfPositionEnum.Rear:
        //        rb.position = surfPosCoords.rear;
        //        break;
        //    case SurfPositionEnum.Mid:
        //        rb.position = surfPosCoords.mid;
        //        break;
        //    case SurfPositionEnum.Forward:
        //        rb.position = surfPosCoords.forward;
        //        break;
        //    default:
        //        break;
        //}
    }
}