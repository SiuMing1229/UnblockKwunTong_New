using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierBehavior : MonoBehaviour
{
    TrafficLightGroupController manager;
    public GameObject barrier;

    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponentInParent<TrafficLightGroupController>();
    }

    // Update is called once per frame
    void Update()
    {
        barrier.SetActive(manager.pass);
    }
}
