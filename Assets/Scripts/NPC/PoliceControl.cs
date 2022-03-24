using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceControl : MonoBehaviour
{
    public Animator policeAnim;

    // Start is called before the first frame update
    void Start()
    {
        policeAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        policeAnim.SetBool("running", true);
    }
}
