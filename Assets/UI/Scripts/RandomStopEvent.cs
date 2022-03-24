using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomStopEvent : MonoBehaviour
{
    public GameObject stopBarrier;
    private bool on;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        on = false;
        timer = Time.time + 5f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time >= timer)
        {
            on = !on;
            timer = Time.time + 5f;
        }
        stopBarrier.SetActive(on);

        
    }
}
