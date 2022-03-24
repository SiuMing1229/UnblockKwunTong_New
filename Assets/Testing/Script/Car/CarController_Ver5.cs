using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController_Ver5 : MonoBehaviour
{
    public float carSpeed;
    public float carMaxSpeed;
    public float carAccelerateSpeed;
    public float carStopSpeed;
    private float tempSpeed;
    [SerializeField] private int wayPointIndex;
    private int routeIndex;
    private float fDist;
    public GameObject[] wayPoints;

    Raycast_Test01 sensor;
    SpawnCarController_Ver01 manager;


    void Start()
    {
        //Set layer mask to "Car"
        gameObject.layer = 7;

        carSpeed = 0;
        carMaxSpeed = 10;
        carAccelerateSpeed = 1;
        wayPointIndex = 0;
        routeIndex = 0;

        sensor = GetComponent<Raycast_Test01>();
        manager = GetComponentInParent<SpawnCarController_Ver01>();      
        if(manager.pathIndex == 0)
        {
            RouteController(routeIndex);
        }
        else if(manager.pathIndex == 1)
        {
            RouteController01(routeIndex);
        }
        else if(manager.pathIndex == 2)
        {
            RouteController02(routeIndex);
        }
        
        transform.LookAt(wayPoints[wayPointIndex].transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        //wayPoints = GameObject.FindGameObjectsWithTag("HYR_FirstSection_Slow");
        SpeedControl();
        fDist = Vector3.Distance(transform.position, wayPoints[wayPointIndex].transform.position);
        if (fDist < 2f)
        {
            IncreaseIndex();
        }
        Movement();
        //transform.LookAt(wayPoints[wayPointIndex].transform.position);
        
    }

    public void Movement()
    {
        carSpeed += tempSpeed;
        transform.Translate(Vector3.forward * carSpeed * Time.deltaTime);
    }

    private void SpeedControl()
    {
        if (!sensor.isHit)
        {
            tempSpeed = carAccelerateSpeed;
        }
        else
        {
            tempSpeed = 0;
            carSpeed = 0;
        }

        if (carSpeed > carMaxSpeed)
        {
            carSpeed = carMaxSpeed;
        }

        if (carSpeed < 0)
        {
            carSpeed = 0;
        }
    }
    void IncreaseIndex()
    {
        wayPointIndex++;
        if (wayPointIndex >= wayPoints.Length)
        {
            //wayPointIndex = 0;
            //Destroy(this.gameObject);
            //wayPoints = GameObject.FindGameObjectsWithTag("HYR_HMS_Slow");
            wayPoints = null;
            wayPointIndex = 0;
            routeIndex++;

            //RouteController(routeIndex);
            if(manager.pathIndex == 0)
        {
            RouteController(routeIndex);
        }
        else if(manager.pathIndex == 1)
        {
            RouteController01(routeIndex);
        }
        else if(manager.pathIndex == 2)
        {
            RouteController02(routeIndex);
        }
        }
        transform.LookAt(wayPoints[wayPointIndex].transform.position);
    }

    private void DistributeRoute(int routeNum)
    {
        if (routeNum == 0)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_WayPoint_Slow");
        }
        else if (routeNum == 1)
        {
            //wayPoints = GameObject.FindGameObjectsWithTag("HYR_WayPoint_Middle");
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_HMS_Slow");
        }
        else if (routeNum == 2)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_WayPoint_Fast");
        }
    }

    private void RouteController(int routeNum)
    {
        if (routeNum == 0)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_FirstSection_Slow");
        }
        else if(routeNum == 1)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_SecondSection_Slow");
        }
        else if(routeNum == 2)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HMS_FirstSection_Slow");
        }
    }

    private void RouteController01(int routeNum)
    {
        if (routeNum == 0)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_FirstSection_Middle");
        }
        else if (routeNum == 1)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_SecondSection_Middle");
        }
        else if (routeNum == 2)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HMS_FirstSection_Middle");
        }
    }

    private void RouteController02(int routeNum)
    {
        if (routeNum == 0)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_FirstSection_Fast");
        }
        else if (routeNum == 1)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_SecondSection_Fast");
        }
        else if (routeNum == 2)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HMS_FirstSection_Fast");
        }
    }

}
