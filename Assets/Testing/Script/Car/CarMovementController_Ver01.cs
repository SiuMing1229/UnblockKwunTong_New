using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementController_Ver01 : MonoBehaviour
{
    public float currentSpeed;
    public float currentAccelerateSpeed;
    public float maxSpeed;
    public float accelerateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Movement()
    {
        currentSpeed += currentAccelerateSpeed;
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }

    public void SpeedControl(bool isMoving)
    {
        if (isMoving)
        {
            currentAccelerateSpeed = accelerateSpeed;   
        }
        else
        {
            currentAccelerateSpeed = 0;
            currentSpeed = 0;
        }

        if(currentSpeed >= maxSpeed)
        {
            currentSpeed = maxSpeed;
        }

        if(currentSpeed < 0)
        {
            currentSpeed = 0;
        }
    }

    public void RandomStopEvent(int mainPathIndex, int currentPathIndex,int waypointIndex)
    {
        if (mainPathIndex == 1 && currentPathIndex == 11 && waypointIndex == 10)
        {
            float tempCurrentSpeed = currentSpeed;
            float tempCurrentAccSpeed = currentAccelerateSpeed;
            float tempAccSpeed = accelerateSpeed;
            currentSpeed = 0;
            currentAccelerateSpeed = 0;
            accelerateSpeed = 0;
            float timer = Time.time + 5f;
            if (timer >= Time.time)
            {
                currentAccelerateSpeed = tempCurrentAccSpeed;
                accelerateSpeed = tempAccSpeed;
            }
            //Debug.Log("Time to Stop");
        }
    }
}
