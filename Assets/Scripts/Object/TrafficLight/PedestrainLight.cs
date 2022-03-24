using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrainLight : MonoBehaviour
{
    public GameObject redPedestrainLight;
    public GameObject greenPedestrainLight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightController(bool red, bool green)
    {
        redPedestrainLight.SetActive(red);
        greenPedestrainLight.SetActive(green);
    }
}
