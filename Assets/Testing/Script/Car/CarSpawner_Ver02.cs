using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarSpawner_Ver02 : MonoBehaviour
{
    public GameObject[] carList;
    private int carListIndex;

    // Start is called before the first frame update
    void Start()
    {
        //var randomIndex = Random.Range(0, carList.Length);
        carListIndex = Random.Range(0, carList.Length);
        carList[carListIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
