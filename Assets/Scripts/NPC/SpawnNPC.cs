using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNPC : MonoBehaviour
{
    public GameObject NonPlayerCharacter;

    [SerializeField] private float fDelay = 3f;
    private int iAmountSpawned = 0;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fDelay >= 3)
        {
            //GameObject temp = Instantiate(NonPlayerCharacter, new Vector3(iAmountSpawned * 5, 0, 0), Quaternion.identity);
            GameObject temp = Instantiate(NonPlayerCharacter, spawnPoint.position, Quaternion.identity);
            temp.name = "NPC" + iAmountSpawned.ToString();
            fDelay = 0;
            iAmountSpawned++;
        }
        fDelay += Time.deltaTime;
    }
}
