 
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]

public class PlayerCharacter : MonoBehaviour
{

    [SerializeField] private float rearLiftForce;
    [SerializeField] private float rearGravForce;

    [SerializeField] private float midLiftForce;
    [SerializeField] private float midGravForce;

    [SerializeField] private float forwardLiftForce;
    [SerializeField] private float forwardGravForce;

    private float currentLiftForce;
    private float currentGravForce;


    [SerializeField] private VelocLimit.VelocityLimit rearMaxLiftVeloc;
    [SerializeField] private VelocLimit.VelocityLimit rearMaxGravVeloc;

    [SerializeField] private VelocLimit.VelocityLimit midMaxLiftVeloc;
    [SerializeField] private VelocLimit.VelocityLimit midMaxGravVeloc;

    [SerializeField] private VelocLimit.VelocityLimit forwardMaxLiftVeloc;
    [SerializeField] private VelocLimit.VelocityLimit forwardMaxGravVeloc;

    private VelocLimit.VelocityLimit currentMaxLift;
    private VelocLimit.VelocityLimit currentMaxGrav;


    [SerializeField] private AngleLimit.AngleLimit rearMaxLiftAngle;
    [SerializeField] private AngleLimit.AngleLimit rearMaxGravAngle;

    [SerializeField] private AngleLimit.AngleLimit midMaxLiftAngle;
    [SerializeField] private AngleLimit.AngleLimit midMaxGravAngle;

    [SerializeField] private AngleLimit.AngleLimit forwardMaxLiftAngle;
    [SerializeField] private AngleLimit.AngleLimit forwardMaxGravAngle;

    private AngleLimit.AngleLimit currentMaxLiftAngle;
    private AngleLimit.AngleLimit currentMaxGravAngle;






    private Rigidbody rb;

    [SerializeField] private Sprite surferSprite1;
    [SerializeField] private Sprite surferSprite2;
    [SerializeField] private Sprite boardSprite;

    private SpriteRenderer[] spriteRenderers;



    private Transform surfboardTrans;
    private Transform playerCharacterTrans;


    private enum SurfPositionEnum
    {
        Rear,
        Mid,
        Forward
    };
    [SerializeField] private SurfPositionEnum startingSurfPosition;
    private SurfPositionEnum currentSurfPos;

    [SerializeField] private SurfPos.SurfPosition surfPosCoords;

    private SpriteRenderer surferSpriteRend;
    private SpriteRenderer boardSpriteRend;

    private bool isLifting;
    private bool isGliding;
    private bool hasBegun = false;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 0);

        currentSurfPos = startingSurfPosition;
        currentMaxLift = midMaxLiftVeloc;
        currentMaxGrav = midMaxGravVeloc;
        currentMaxLiftAngle = midMaxLiftAngle;
        currentMaxGravAngle = midMaxGravAngle;


        surfboardTrans = gameObject.transform.Find("SurfBoard");
        playerCharacterTrans = gameObject.transform.Find("PlayerCharacter");

        boardSpriteRend = surfboardTrans.gameObject.GetComponent<SpriteRenderer>();
        surferSpriteRend = playerCharacterTrans.gameObject.GetComponent<SpriteRenderer>();

        boardSpriteRend.sprite = boardSprite;
        surferSpriteRend.sprite = surferSprite1;


    }

    public void OnLift(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            isLifting = true;
            hasBegun = true;
            Debug.Log("Lifting");
        }
        else if (context.canceled == true)
        {
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
        if (context.started == true)
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
    }

    public void OnShiftRight(InputAction.CallbackContext context)
    {
        if (context.started == true)
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

    }
    void FixedUpdate()
    {




        if (isGliding == true)
        {
            rb.velocity = Vector3.zero;
        }
        else if (isLifting == true)
        {
            if (rb.velocity.y <= currentMaxLift.maxVelocity.y)
            {
                rb.AddForce(new Vector3(0f, currentLiftForce, 0f));
            }
        }
        else if (isLifting == false)
        {
            if (hasBegun == true)
            {
                if (rb.velocity.y >= currentMaxGrav.maxVelocity.y)
                {
                    rb.AddForce(new Vector3(0f, currentGravForce, 0f));
                }
            }
        }

        

        switch (currentSurfPos)
        {
            case SurfPositionEnum.Rear:
                playerCharacterTrans.localPosition = surfPosCoords.rear;
                currentLiftForce = rearLiftForce;
                currentGravForce = rearGravForce;
                currentMaxLift = rearMaxLiftVeloc;
                currentMaxGrav = rearMaxGravVeloc;
                currentMaxLiftAngle = rearMaxLiftAngle;
                currentMaxGravAngle = rearMaxGravAngle;

                break;
            case SurfPositionEnum.Mid:
                playerCharacterTrans.localPosition = surfPosCoords.mid;
                currentLiftForce = midLiftForce;
                currentGravForce = midGravForce;
                currentMaxLift = midMaxLiftVeloc;
                currentMaxGrav = midMaxGravVeloc;
                currentMaxLiftAngle = midMaxLiftAngle;
                currentMaxGravAngle = midMaxGravAngle;
                break;
            case SurfPositionEnum.Forward:
                playerCharacterTrans.localPosition = surfPosCoords.forward;
                currentLiftForce = forwardLiftForce;
                currentGravForce = forwardGravForce;
                currentMaxLift = forwardMaxLiftVeloc;
                currentMaxGrav = forwardMaxGravVeloc;
                currentMaxLiftAngle = forwardMaxLiftAngle;
                currentMaxGravAngle = forwardMaxGravAngle;
                break;
            default:
                break;
        }

        if (rb.velocity.y > 0)
        {
            rb.MoveRotation(Quaternion.Euler(0f, 0f, (currentMaxLiftAngle.maxAngle * rb.velocity.y) / currentMaxLift.maxVelocity.y));
        }
        else if (rb.velocity.y < 0)
        {
            rb.MoveRotation(Quaternion.Euler(0f, 0f, (currentMaxGravAngle.maxAngle * rb.velocity.y) / currentMaxGrav.maxVelocity.y));
        }


        if (rb.velocity.y > 0)
        {
            surferSpriteRend.sprite = surferSprite1;
        }
        else
        {
            surferSpriteRend.sprite = surferSprite2;
        }


        Debug.Log("Position is now: " + currentSurfPos);
    }
}

