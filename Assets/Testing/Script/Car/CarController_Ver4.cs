using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController_Ver4 : MonoBehaviour
{
    public float carSpeed;
    public float carMaxSpeed;
    public float carAccelerateSpeed;
    public float carStopSpeed;
    private float tempSpeed;

    //FieldOfView sensor;
    Raycast_Test01 sensor;
    SpawnCarController_Ver01 spawnCarController;
 
    //public int routeIndex;
    public GameObject[] wayPoints;
    private int wayPointIndex;
    //public string wayPointName;

    private float fDist;

    //NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        //Set layer mask to "Car"
        gameObject.layer = 7;

        carSpeed = 0;
        carMaxSpeed = 10;
        carAccelerateSpeed = 1;
        wayPointIndex = 0;

        //sensor = GetComponent<FieldOfView>();
        sensor = GetComponent<Raycast_Test01>();
        spawnCarController = GetComponentInParent<SpawnCarController_Ver01>();
        //DistributeRoute(tempRouteNum);
        DistributeRoute(spawnCarController.pathIndex);
        transform.LookAt(wayPoints[wayPointIndex].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        SpeedControl();
        fDist = Vector3.Distance(transform.position, wayPoints[wayPointIndex].transform.position);
        if (fDist < 2f)
        {
            IncreaseIndex();
        }
        Movement();
        //transform.LookAt(wayPoints[wayPointIndex].transform.position);
        //Debug.Log(wayPoints[0].transform.position);
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

        if(carSpeed > carMaxSpeed)
        {
            carSpeed = carMaxSpeed;
        }

        if(carSpeed < 0)
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
            Destroy(this.gameObject);
            wayPoints = GameObject.FindGameObjectsWithTag("");
        }
        transform.LookAt(wayPoints[wayPointIndex].transform.position);
    }

    private void DistributeRoute(int routeNum)
    {
        if(routeNum == 0)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_WayPoint_Slow");
        }
        else if(routeNum == 1)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_WayPoint_Middle");
        }
        else if(routeNum == 2)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_WayPoint_Fast");
        }
    }
}
