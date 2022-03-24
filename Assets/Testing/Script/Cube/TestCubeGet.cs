using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCubeGet : MonoBehaviour
{
    public float x;
    WayPointPro manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = transform.parent.parent.parent.gameObject.GetComponent<WayPointPro>();
        x = manager.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
