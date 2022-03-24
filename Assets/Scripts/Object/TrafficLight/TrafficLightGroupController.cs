using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightGroupController : TrafficLightManager
{
    public int roadIndex;
    private float roadTimer;
    private float pedTimer;
    private int pedIndex;

    [SerializeField] private float redLightDuration;
    [SerializeField] private float yellowLightDuration;
    [SerializeField] private float greenLightDuration;
    [SerializeField] private float redYellowLightDuration;

    //public GameObject barrier;

    // Start is called before the first frame update
    void Start()
    {
        redLightOn = false;
        yellowLightOn = false;
        greenLightOn = false;
        pass = false;

        //delay = greenLightDuration;
        //roadTimer = Time.time + delay;
        roadTimer = delay;
    }

    // Update is called once per frame
    void Update()
    {
        IndexController();
        ChangeMode(roadIndex);
        //float roadTimer = delay;
        //barrier.SetActive(pass);

    }

    private void IndexController()
    {
        if (Time.time >= roadTimer)
        {
            roadTimer = Time.time + delay;
            roadIndex++;
        }

        if (roadIndex == 0)
        {
            // Green Light
            delay = yellowLightDuration;
            pass = false;
        }
        else if (roadIndex == 1)
        {
            // Yellow Light
            delay = redLightDuration;
            pass = true;
        }
        else if (roadIndex == 2)
        {
            //Red Light
            delay = redYellowLightDuration;
            pass = true;
        }
        else if (roadIndex == 3)
        {
            //Red & Yellow Light
            delay = greenLightDuration;
            pass = true;
        }

        if (roadIndex >= 4 || roadIndex < 0)
        {
            roadIndex = 0;
        }
    }
}
