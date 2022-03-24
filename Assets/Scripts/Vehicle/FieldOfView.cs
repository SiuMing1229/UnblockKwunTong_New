using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float radius;
    [Range(0, 360)] public float angle;

    //public GameObject playerRef;

    public LayerMask targetMask;
    public LayerMask obsructionMask;

    public bool toStop;
    CarController_Ver3 controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CarController_Ver3>();
        //playerRef = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(FOVRountine());

    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator FOVRountine()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);
        while (true)
        {
            yield return wait;
            FieldOfViewCheck();
        }
    }

    private void FieldOfViewCheck()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, targetMask);
        int iPlayerCount = 0;
        if(rangeChecks.Length != 0)
        {
            Transform target = rangeChecks[0].transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;
            if(Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);
                if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, obsructionMask))
                {
                    iPlayerCount++;
                }
            }
            toStop = (iPlayerCount > 0);
        }else if (toStop)
        {
            toStop = false;
        }
    }
}
