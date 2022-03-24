using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Transform[] wayPoints;
    public float FSpeed;

    private int wayPointIndex;
    private float fDist;

    // Start is called before the first frame update
    void Start()
    {
        wayPointIndex = 0;
        transform.LookAt(wayPoints[wayPointIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
        fDist = Vector3.Distance(transform.position, wayPoints[wayPointIndex].position);
        if (fDist < 1f)
        {
            IncreaseIndex();
        }
        Patrol();
    }

    void Patrol()
    {
        transform.Translate(Vector3.forward * FSpeed * Time.deltaTime);
    }

    void IncreaseIndex()
    {
        wayPointIndex++;
        if (wayPointIndex >= wayPoints.Length)
        {
            //wayPointIndex = 0;
            //Destroy(this.gameObject);
            FSpeed = 0;
        }
        transform.LookAt(wayPoints[wayPointIndex].position);
    }


}
