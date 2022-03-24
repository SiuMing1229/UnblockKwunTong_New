using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightManager : MonoBehaviour
{
    public bool redLightOn;
    public bool yellowLightOn;
    public bool greenLightOn;

    public bool pedestrainRedOn;
    public bool pedestrainGreenOn;

    public bool pass;
    public float delay;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMode(int roadIndex)
    {
        if (roadIndex == 0)
        {
            GreenLightOn();
        }
        else if (roadIndex == 1)
        {
            YellowLightOn();
        }
        else if (roadIndex == 2)
        {
            RedLightOn();
        }
        else if (roadIndex == 3)
        {
            RedYellowLightOn();
        }
        else if (roadIndex >= 4 || roadIndex < 0)
        {
            roadIndex = 0;
        }
    }

    public void GreenLightOn()
    {
        redLightOn = false;
        yellowLightOn = false;
        greenLightOn = true;
        pedestrainGreenOn = false;
        pedestrainRedOn = true;
    }

    public void YellowLightOn()
    {
        redLightOn = false;
        yellowLightOn = true;
        greenLightOn = false;
        pedestrainGreenOn = false;
        pedestrainRedOn = true;
    }

    public void RedLightOn()
    {
        redLightOn = true;
        yellowLightOn = false;
        greenLightOn = false;
        pedestrainGreenOn = true;
        pedestrainRedOn = false;
    }

    public void RedYellowLightOn()
    {
        redLightOn = true;
        yellowLightOn = true;
        greenLightOn = false;
        pedestrainGreenOn = false;
        pedestrainRedOn = true;
    }
}
