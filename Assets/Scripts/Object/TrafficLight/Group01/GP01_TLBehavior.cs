using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GP01_TLBehavior : TrafficLight
{
    GP01_TLManager manager;

    // Start is called before the first frame update
    void Start()
    {
        //manager = GetComponent<GP01_TLManager>();
        manager = GetComponentInParent<GP01_TLManager>();
    }

    // Update is called once per frame
    void Update()
    {
        LightController(manager.redLightOn, manager.yellowLightOn, manager.greenLightOn);
    }
}
