using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarNav : MonoBehaviour
{
    public Transform targetPosition;
    private NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        targetPosition = GameObject.FindGameObjectWithTag("target").transform;
    }

    private void Update()
    {
        navMeshAgent.destination = targetPosition.position;


    }

    private bool Collided(Transform target, NavMeshAgent car)
    {
        bool collided = false;


        return collided;
    }
}
