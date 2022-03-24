using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AverageSpeed : MonoBehaviour
{
    Text text;
    GameObject speedManager;
    CarMovementController_Ver01 speedController;
    int vehicleCount;
    float totalSpeed;

    GameObject number;
    VehicleNumber vehicleNumber;

    GameObject[] cars;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        speedManager = GameObject.Find("HYR_SlowSpawnPoint");
        speedController = speedManager.GetComponent<CarMovementController_Ver01>();
        number = GameObject.Find("Vehicle Number Text");
        vehicleNumber = number.GetComponent<VehicleNumber>();
        cars = GameObject.FindGameObjectsWithTag("Car");
    }

    // Update is called once per frame
    void Update()
    {
        //vehicleCount = vehicleNumber.totalCount;

        //for(int i = 0; i < cars.Length; i++)
        //{
        //    totalSpeed += cars[i].GetComponent<CarMovementController_Ver01>().currentSpeed;
        //}

        //text.text = totalSpeed.ToString();
    }
}
