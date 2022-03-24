using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightBehavior : TrafficLight
{
    TrafficLightGroupController manager;

    // Start is called before the first frame update
    void Start()
    {
        //manager = GetComponent<GP01_TLManager>();
        manager = GetComponentInParent<TrafficLightGroupController>();
    }

    // Update is called once per frame
    void Update()
    {
        LightController(manager.redLightOn, manager.yellowLightOn, manager.greenLightOn);
    }
}
