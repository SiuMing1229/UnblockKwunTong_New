using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementController_Ver02 : MonoBehaviour
{
    public float currentSpeed;
    public float accSpeed;
    private const float MAXSPEED = 15f; 

    public bool stopMode;
    public bool normalMode;
    public bool turningMode;
    public bool slowdownMode;
    public bool parkingMode;

    [SerializeField] private float timer;

    FrontSensor frontSensor;


    private void Start()
    {
        currentSpeed = 0f;
        accSpeed = 0.4f;
        InitializedSpeedController();
        timer = 0f;
        //frontSensor = GetComponentInChildren<Raycast_Ver2>();
        //frontSensor = GetComponentInChildren<FrontSensor>();
        frontSensor = transform.GetChild(0).GetChild(0).GetComponent<FrontSensor>();
    }

    private void Update()
    {
        SpeedLimitedController();
        ModeController();
    }

    public void InitializedSpeedController()
    {
        normalMode = true;
        stopMode = false;
        turningMode = false;
    }

    public void ModeController()
    {
        if (normalMode)
        {
            normalModeController();
        }
        else if (stopMode)
        {
            StopModeController();
        }
        else if (turningMode)
        {

        }
        else
        {
            normalModeController();
        }

        if (frontSensor.isHit)
        {
            stopMode = true;
            normalMode = false;
        }
        else if (!frontSensor.isHit)
        {
            normalMode = true;
            stopMode = false;
        }
    }

    public void normalModeController()
    {
        if (Time.time >= timer && currentSpeed >= 0 && currentSpeed < MAXSPEED) {
            accSpeed = 0.4f;
            currentSpeed += accSpeed;
            timer = Time.time + 0.1f;
        }
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }

    public void StopModeController()
    {
        currentSpeed = 0;
        accSpeed = 0;
    }

    public void TurningModeConreoller()
    {
        currentSpeed = 0;
        accSpeed = 0;
        Debug.Log("This is turning");
        gameObject.transform.Rotate(0.0f, 40.0f, 0.0f, Space.Self);

    }

    public void ParkingMode()
    {
        currentSpeed = 0;
        accSpeed = 0;
    }

    public void SlowdownModeController()
    {
        if (Time.time >= timer && currentSpeed < MAXSPEED)
        {
            currentSpeed -= accSpeed;
            timer = Time.time + 0.1f;
            //Debug.Log("Timer updated");
        }
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }

    private void SpeedLimitedController()
    {
        if(currentSpeed >= MAXSPEED)
        {
            currentSpeed = MAXSPEED;
        }
        if(currentSpeed < 0)
        {
            currentSpeed = 0;
        }
    }

    public void HitByOther()
    {
        Debug.Log("Raycast Success!!");
        normalMode = false;
        stopMode = true;
    }

    
}
