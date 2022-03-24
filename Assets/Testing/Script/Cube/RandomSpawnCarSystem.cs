using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnCarSystem : MonoBehaviour
{
    public float totalTime;
    public int numOfCarSpawn;
    public float[] spawningSchedule;
    public float basicSpawnRate;
    public float testTotalTime;

    // Start is called before the first frame update
    void Start()
    {
        spawningSchedule = new float[numOfCarSpawn];
        basicSpawnRate = totalTime / numOfCarSpawn; // = 6s spawn 1 car
        float timeCompensate = 0;
        for (int i = 0; i < numOfCarSpawn - 1; i++)
        {
            float thisRanDelayTime = Random.Range(basicSpawnRate - 1.5f, basicSpawnRate + 1.5f);
            spawningSchedule[i] = thisRanDelayTime;
            timeCompensate += spawningSchedule[i];
            testTotalTime += spawningSchedule[i];
        }
        spawningSchedule[spawningSchedule.Length - 1] = totalTime - timeCompensate;
        testTotalTime += spawningSchedule[spawningSchedule.Length - 1];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
