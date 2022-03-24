using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathController_Ver01 : MonoBehaviour
{
    //Path manager;

    public GameObject[] currentPath = null;
    public int currentPathIndex = 0;
    public int nextPathIndex = 0;
    public int secondPathIndex = 0;
    public int mainPathIndex = 0;
    public int nextMainPathIndex = 0;
    public int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        //manager = transform.parent.parent.gameObject.GetComponent<Path>();
        /*currentPath = null;
        currentPathIndex = 61;
        nextPathIndex = 0;
        waypointIndex = 0;
        mainPathIndex = 2;
        nextMainPathIndex = 0;*/
    }

    private void Update()
    {
        
    }

    public int MainIndexController(int mainIndex)
    {
        if(mainIndex == 10)
        {
            int ran = Random.Range(0, 3);
            return ran + 1;
        }
        else if(mainIndex == 12)
        {
            int ran = Random.Range(0, 2);
            return ran + 1;
        }
        else if (mainIndex == 23)
        {
            int ran = Random.Range(2, 4);
            return ran;
        }
        else if(mainIndex == 34)
        {
            int ran = Random.Range(3, 5);
            return ran;
        }
        else
        {
            return mainIndex;
        }
    }
}
