using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarControllerVer2 : MonoBehaviour
{
    public NavMeshAgent agent;

    public GameObject[] target;
    public int targetIndex;
    private float distanceBetween;

    public int carID;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targetIndex = 0;
        //agent.speed = 0;
        //carID = CarManager_Testing.count;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Target Position"+target[targetIndex].transform.position);
        distanceBetween = Vector3.Distance(transform.position, target[targetIndex].transform.position);
        if (distanceBetween < 1f)
        {
            IncreaseTargetIndex();
        }
        Movement();
        //agent.SetDestination(testingTarget.position);
        //transform.Translate(testingTarget.position);
    }

    public CarControllerVer2(int id)
    {
        this.carID = id;
    }

    public void Movement()
    {
        agent.SetDestination(target[targetIndex].transform.position);
        //agent.SetDestination(testingTarget.position);
        //transform.LookAt(target[targetIndex].position);
    }

    private void IncreaseTargetIndex()
    {
        targetIndex++;
        if(targetIndex >= target.Length)
        {
            DestroyCar();
            //targetIndex = 0;
        }
    }

    private void DestroyCar()
    {
        Destroy(this.gameObject);
    }

    private void StopMoving()
    {
        //Transform currentPosition = this.gameObject.position;
        //agent.SetDestination(new )
    }

    private void CheckDistance(GameObject nextCar)
    {
        if(nextCar.tag == "Car")
        {

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Car")
        {
            Debug.Log("Collision Dected");
            agent.speed = 0;
            //Vector3 currentPosition = agent.transform.position;
            Debug.Log(agent.transform.position);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        agent.speed = 3;
    }
}
