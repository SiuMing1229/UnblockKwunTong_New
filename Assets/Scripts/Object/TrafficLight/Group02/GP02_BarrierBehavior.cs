using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GP02_BarrierBehavior : MonoBehaviour
{
    GP02_TLMamager manager;
    public GameObject barrier;

    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponentInParent<GP02_TLMamager>();
    }

    // Update is called once per frame
    void Update()
    {
        barrier.SetActive(manager.pass);
    }
}
