using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarController_Ver3 : MonoBehaviour
{
    public float carSpeed;
    public float carMaxSpeed;
    public float carAccelerateSpeed;
    public float carStopSpeed;
    private float tempSpeed;

    FieldOfView sensor;
    SpawnCarController_Ver01 manager;
 
    //public int routeIndex;
    public GameObject[] wayPoints;
    private int wayPointIndex;
    //public string wayPointName;

    private float fDist;

    //NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        carSpeed = 0;
        wayPointIndex = 0;

        sensor = GetComponent<FieldOfView>();
        manager = GetComponentInParent<SpawnCarController_Ver01>();
        //agent = GetComponent<NavMeshAgent>();
        DistributeRoute();
        //wayPoints = GameObject.FindGameObjectsWithTag("HYR_WayPoint_Slow");
        //wayPoints = GameObject.FindGameObjectsWithTag(wayPointName);
        transform.LookAt(wayPoints[wayPointIndex].transform.position);
        gameObject.layer = 7;

        carMaxSpeed = 8;
        carAccelerateSpeed = 1;
        
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
        if (!sensor.toStop)
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
        }
        transform.LookAt(wayPoints[wayPointIndex].transform.position);
    }

    private void DistributeRoute()
    {
        if(manager.pathIndex == 0)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_WayPoint_Slow");
        }
        else if(manager.pathIndex == 1)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_WayPoint_Middle");
        }
        else if(manager.pathIndex == 2)
        {
            wayPoints = GameObject.FindGameObjectsWithTag("HYR_WayPoint_Fast");
        }
    }

}
