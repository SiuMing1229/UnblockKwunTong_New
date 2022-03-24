using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointTester : MonoBehaviour
{
    public GameObject[] waypoint;
    WayPointManager manager;
    public Vector3 testPoint;
    public int y;

    // Start is called before the first frame update
    void Start()
    {
        //manager = GetComponent<WayPointManager>();
        manager = GetComponentInParent<WayPointManager>();
        waypoint[0] = manager.HYR_FirstSection_Slow[0];
        testPoint = manager.HYR_FirstSection_Slow[0].transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {
        y = manager.x;
    }
}
