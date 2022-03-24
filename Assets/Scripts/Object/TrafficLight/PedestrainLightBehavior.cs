using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrainLightBehavior : PedestrainLight
{
    TrafficLightGroupController manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponentInParent<TrafficLightGroupController>();
    }

    // Update is called once per frame
    void Update()
    {
        LightController(manager.pedestrainRedOn, manager.pedestrainGreenOn);
    }
}
