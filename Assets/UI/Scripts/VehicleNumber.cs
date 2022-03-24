using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VehicleNumber : MonoBehaviour
{
    Text text;
    GameObject[] carManagers;
    SpawnCarController_Ver01[] spawnControllers;
    public int totalCount;

    // Start is called before the first frame update
    void Start()
    {
        carManagers = new GameObject[3];
        spawnControllers = new SpawnCarController_Ver01[3];

        text = GetComponent<Text>();
        carManagers[0] = GameObject.Find("HYR_SlowSpawnPoint");
        spawnControllers[0] = carManagers[0].GetComponent<SpawnCarController_Ver01>();

        carManagers[1] = GameObject.Find("HYR_MiddleSpawnPoint");
        spawnControllers[1] = carManagers[0].GetComponent<SpawnCarController_Ver01>();

        carManagers[2] = GameObject.Find("HYR_FastSpawnPoint");
        spawnControllers[2] = carManagers[0].GetComponent<SpawnCarController_Ver01>();
    }

    // Update is called once per frame
    void Update()
    {
        totalCount = spawnControllers[0].count + spawnControllers[1].count + spawnControllers[2].count;

        text.text = totalCount.ToString();
    }
}
