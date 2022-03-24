using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointManager : MonoBehaviour
{
    public GameObject[] HYR_FirstSection_Slow;
    public GameObject[] HYR_FirstSection_Middle;
    public GameObject[] HYR_FirstSection_Fast;
    public Vector3 testpoint;
    public int x = 5;

    // Start is called before the first frame update
    void Start()
    {
        HYR_FirstSection_Slow = GameObject.FindGameObjectsWithTag("HYR_FirstSection_Slow");
        HYR_FirstSection_Middle = GameObject.FindGameObjectsWithTag("HYR_FirstSection_Middle");
        HYR_FirstSection_Fast = GameObject.FindGameObjectsWithTag("HYR_FirstSection_Fast");
        testpoint = HYR_FirstSection_Fast[0].transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(wayPoints.ToString());
    }

    public GameObject[] GetHYR_FirstSection_Slow()
    {
        return HYR_FirstSection_Slow;
    }
}
