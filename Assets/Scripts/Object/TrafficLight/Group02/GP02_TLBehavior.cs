using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GP02_TLBehavior : TrafficLight
{
    GP02_TLMamager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponentInParent<GP02_TLMamager>();
    }

    // Update is called once per frame
    void Update()
    {
        LightController(manager.redLightOn, manager.yellowLightOn, manager.greenLightOn);
    }
}
