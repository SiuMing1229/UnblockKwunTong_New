using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CarController_Testing : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] private float carSpeed = 10f;
    [SerializeField] private float torque = 0.01f;
    [SerializeField] private float maxSpeed = 3;

   [SerializeField]  private Vector2 movementVector;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(movementVector.y * transform.forward * carSpeed);
        }

        rb.AddTorque(movementVector.x * Vector3.up * torque * movementVector.y);
    }

    public void Move(Vector2 movementInput)
    {
        this.movementVector = movementInput; 
    }
}
