using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController_Ver6 : MonoBehaviour
{
    public float carSpeed;
    public float carMaxSpeed;
    public float carAccelerateSpeed;
    public float carStopSpeed;
    private float tempSpeed;
    [SerializeField] private int wayPointIndex;
    private float nextWaypointDistance;
    //public GameObject[] currentPath;

    Raycast_Test01 sensor;
    Path_Ver01 pathManager;
    PathController_Ver01 pathController;

    //Debug Used
    public int showNextPathIndex;
    public GameObject[] showCurrentPath;
    

    void Start()
    {
        //Set layer mask to "Car"
        gameObject.layer = 7;

        carSpeed = 0;
        carMaxSpeed = 10;
        carAccelerateSpeed = 1;
        wayPointIndex = 0;

        sensor = GetComponent<Raycast_Test01>();        
        pathManager = transform.parent.parent.gameObject.GetComponent<Path_Ver01>();
        pathController = GetComponent<PathController_Ver01>();

        //Set current path
        pathController.currentPathIndex = 11;
        //transform.LookAt(currentPath[wayPointIndex].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //pathController.currentPath = pathManager.slowPath[pathController.currentPathIndex].path;
        //pathController.nextPathIndex = pathManager.slowPath[pathController.currentPathIndex].nextPathIndex;
        showCurrentPath = pathController.currentPath;
        showNextPathIndex = pathController.nextPathIndex;
        //transform.LookAt(currentPath[wayPointIndex].transform.position);
        SpeedControl();
        nextWaypointDistance = Vector3.Distance(transform.position, pathController.currentPath[wayPointIndex].transform.position);
        if (nextWaypointDistance < 2f)
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
        if (wayPointIndex >= pathController.currentPath.Length)
        {
            wayPointIndex = 0;
            pathController.currentPathIndex = pathController.nextPathIndex;
            //pathController.nextPathIndex = pathManager.slowPath[pathController.currentPathIndex].nextPathIndex;
            //pathController.currentPath = pathManager.slowPath[pathController.currentPathIndex].path;

        }

        transform.LookAt(pathController.currentPath[wayPointIndex].transform.position);
    }

}
