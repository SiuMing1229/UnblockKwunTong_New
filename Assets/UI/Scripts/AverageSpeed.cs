using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AverageSpeed : MonoBehaviour
{
    Text text;
    GameObject carManager_HYR_Slow, carManager_HYR_Middle, carManager_HYR_Fast;
    //CarMovementController_Ver01 speedController;
    int vehicleCount;
    float totalSpeed, averageSpeed;

    GameObject number;
    VehicleNumber vehicleNumber;

    List<GameObject> cars_slow, cars_middle, cars_fast;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        carManager_HYR_Slow = GameObject.Find("HYR_SlowSpawnPoint");
        carManager_HYR_Middle = GameObject.Find("HYR_MiddleSpawnPoint");
        carManager_HYR_Fast = GameObject.Find("HYR_FastSpawnPoint");
        //speedController = carManager.GetComponent<CarMovementController_Ver01>();

        number = GameObject.Find("Vehicle Number Count");
        vehicleNumber = number.GetComponent<VehicleNumber>();

        cars_slow = carManager_HYR_Slow.GetComponent<SpawnCarController_Ver01>().cars;
        cars_middle = carManager_HYR_Middle.GetComponent<SpawnCarController_Ver01>().cars;
        cars_fast = carManager_HYR_Fast.GetComponent<SpawnCarController_Ver01>().cars;

    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i< cars_slow.Count; i++)
        {
            totalSpeed = 0;
            totalSpeed += cars_slow[i].GetComponent<CarMovementController_Ver01>().currentSpeed;
            totalSpeed += cars_middle[i].GetComponent<CarMovementController_Ver01>().currentSpeed;
            totalSpeed += cars_fast[i].GetComponent<CarMovementController_Ver01>().currentSpeed;
        }

        vehicleCount = vehicleNumber.totalCount;
        averageSpeed = totalSpeed / vehicleCount;
        text.text = averageSpeed.ToString();
    }
}
