using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GP01_BarrierBehavior : MonoBehaviour
{
    GP01_TLManager manager;
    public GameObject barrier;

    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponentInParent<GP01_TLManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        barrier.SetActive(manager.pass);
        
    }
}
