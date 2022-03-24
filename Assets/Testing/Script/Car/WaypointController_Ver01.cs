using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointController_Ver01 : MonoBehaviour
{
    WayPointPro manager;

    public GameObject[] waypointList;

    private int waypointIndex;
    //private 


    //public GameObject[] testWaypoint2;
    public float x;
    


    // Start is called before the first frame update
    void Start()
    {
        manager = transform.parent.parent.parent.gameObject.GetComponent<WayPointPro>();
        x = manager.y;
    }

    // Update is called once per frame
    void Update()
    {
        //testWaypoint = manager.GetHYR_FS_Slow();
    }

    void IncreaseIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypointList.Length)
        {
            //wayPointIndex = 0;
            //Destroy(this.gameObject);
            //wayPoints = GameObject.FindGameObjectsWithTag("HYR_HMS_Slow");
            waypointList = null;
            waypointIndex = 0;
            //routeIndex++;
            transform.LookAt(waypointList[waypointIndex].transform.position);
        }
    }


}
