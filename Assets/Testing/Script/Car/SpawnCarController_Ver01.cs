using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnCarController_Ver01 : MonoBehaviour
{
    public GameObject carPrefab;
    public Transform startPosition;
    public int mainPathIndex;
    public int pathIndex;
    public int waypointIndex;
    [SerializeField] private float adjustAngle;
    [SerializeField] private float timer;
    //[SerializeField] private float spawnRatePerSec;
    [SerializeField] private float ranDelayTime;
    public int count;

    //public Transform hyr;
    public List<GameObject> cars;

    Raycast_Test01 sensor;

    //Random Spawn Car System
    public float totalTime;
    public int numOfCarSpawn;
    public float[] spawningSchedule;
    public float basicSpawnRate;
    //public float testTotalTime;
    public int spawnIndex;

    private void Awake()
    {

    }
    void Start()
    {
        sensor = GetComponentInChildren<Raycast_Test01>();

        //CreateCar();
        //ranDelayTime = Random.Range(3f, 7f);
        //timer = Time.time + ranDelayTime;

        if(totalTime == 0)
        {
            totalTime = 30;
        }
        if(numOfCarSpawn == 0)
        {
            numOfCarSpawn = 6;
        }
        //spawnIndex = 0;
        UpdateSpawnCarSchedule();
        timer = Time.time + spawningSchedule[spawnIndex];

        //hyr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timer && !sensor.isHit)
        {
            CreateCar();
            //ranDelayTime = Random.Range(3, 7);
            //timer = Time.time + ranDelayTime;    
            //timer = Time.time + spawnRatePerSec;
            //spawnIndex++;
            //if (spawnIndex >= numOfCarSpawn+1)
            //timer = Time.time + spawningSchedule[spawnIndex];
            //timer = Time.time + spawningSchedule[spawnIndex];
            if (spawnIndex == numOfCarSpawn)
            {
                UpdateSpawnCarSchedule();
            }
            spawnIndex++;
            timer = Time.time + spawningSchedule[spawnIndex];
        }

        
    }

    public void CreateCar()
    {
        GameObject cloneCar = Instantiate(carPrefab, startPosition.position, Quaternion.Euler(0f, adjustAngle, 0f));
        cloneCar.name = "Car " + count;
        cloneCar.transform.SetParent(this.transform);
        count++;
        cars = AddToCars(cars, cloneCar);
    }

    List<GameObject> AddToCars(List<GameObject> _cars, GameObject _car)
    {
        _cars.Add(_car);

        return _cars;
    }

    private void UpdateSpawnCarSchedule()
    {
        CreateCar();
        spawnIndex = 0;
        spawningSchedule = new float[numOfCarSpawn];
        basicSpawnRate = totalTime / numOfCarSpawn; // = 6s spawn 1 car
        float timeCompensate = 0;
        for (int i = 0; i < numOfCarSpawn - 1; i++)
        {
            float thisRanDelayTime = Random.Range(basicSpawnRate - 1.5f, basicSpawnRate + 1.5f);
            spawningSchedule[i] = thisRanDelayTime;
            timeCompensate += spawningSchedule[i];
            //testTotalTime += spawningSchedule[i];
        }
        spawningSchedule[spawningSchedule.Length - 1] = totalTime - timeCompensate;
        //testTotalTime += spawningSchedule[spawningSchedule.Length - 1];
    }

}
