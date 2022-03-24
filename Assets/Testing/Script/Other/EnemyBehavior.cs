using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float eSpeed;

    // Start is called before the first frame update
    void Start()
    {
        eSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(Vector3.forward * eSpeed * Time.deltaTime);

    }
}
