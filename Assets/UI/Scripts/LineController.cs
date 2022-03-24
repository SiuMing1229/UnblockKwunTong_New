using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    private LineRenderer lr;
    private Transform[] points;

    GameObject carManager;
    SpawnCarController_Ver01 carController;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
        carManager = GameObject.Find("HYR_SlowSpawnPoint");
        carController = carManager.GetComponent<SpawnCarController_Ver01>();
    }

    public void SetUpLine(Transform[] _points)
    {
        lr.positionCount = _points.Length;
        points = _points;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
            lr.material.color = Color.green;
            //lr.alignment = LineAlignment.Local;
        }

        if (carController.count > 2 && carController.count <= 3)
        {
            lr.material.color = new Color(255, 140, 0);
        }
        else if (carController.count > 4 && carController.count <= 5)
        {
            lr.material.color = Color.red;
        }
    }
}
