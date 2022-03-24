using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarController : MonoBehaviour
{
    private NavMeshAgent agent = null;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        transform.LookAt(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        agent.SetDestination(target.position);
    }
}
