using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager_Ver01 : MonoBehaviour
{
    private float nextWaypointDistance;

    CarMovementController_Ver01 speedController;
    Raycast_Test01 sensor;
    Path_Ver01 pathManager;
    PathController_Ver01 pathController;
    SpawnCarController_Ver01 spawnController;

    //Debug Used
    public int showNextPathIndex;
    public GameObject[] showCurrentPath;


    void Start()
    {
        //Set layer mask to "Car"
        gameObject.layer = 7;

        speedController = GetComponent<CarMovementController_Ver01>();
        sensor = GetComponent<Raycast_Test01>();
        pathManager = transform.parent.parent.gameObject.GetComponent<Path_Ver01>();
        pathController = GetComponent<PathController_Ver01>();
        spawnController = GetComponentInParent<SpawnCarController_Ver01>();

        //Set Speed
        speedController.currentSpeed = 0;
        speedController.accelerateSpeed = 1;
        speedController.maxSpeed = 10;

        //Set current path
        pathController.mainPathIndex = spawnController.mainPathIndex;
        pathController.currentPathIndex = spawnController.pathIndex;
        pathController.waypointIndex = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //pathController.currentPath = pathManager.GetPath(pathController.mainPathIndex, pathController.currentPathIndex);
        //pathController.nextPathIndex = pathManager.GetNextPathID(pathController.mainPathIndex, pathController.currentPathIndex);

        speedController.SpeedControl(!sensor.isHit);
        speedController.Movement();
        nextWaypointDistance = Vector3.Distance(transform.position, pathController.currentPath[pathController.waypointIndex].transform.position);
        if (nextWaypointDistance < 2f)
        {
            IncreaseIndex();
        }

        //Debug Used
        //showCurrentPath = pathManager.GetPath(0, 11);
        //showNextPathIndex = pathController.nextPathIndex;
    }

    void IncreaseIndex()
    {
        pathController.waypointIndex++;
        if (pathController.waypointIndex >= pathController.currentPath.Length)
        {
            pathController.waypointIndex = 0;
            //pathController.mainPathIndex = pathController.nextMainPathIndex;
            pathController.currentPathIndex = pathController.nextPathIndex;

            //pathController.currentPath = pathManager.GetPath(pathController.mainPathIndex, pathController.currentPathIndex);
            //pathController.nextPathIndex = pathManager.GetNextPathID(pathController.mainPathIndex, pathController.currentPathIndex);
            
        }

        transform.LookAt(pathController.currentPath[pathController.waypointIndex].transform.position);
    }

}
