using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongestionController : MonoBehaviour
{
    public MeshRenderer[] congestionLevel;
    public float timeToChange = 1.0f;
    float timeSinceChange = 0f;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < congestionLevel.Length; i++)
        {
            congestionLevel[i] = this.gameObject.transform.GetChild(i).GetComponent<MeshRenderer>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        timeSinceChange += Time.deltaTime;

        if (timeSinceChange >= timeToChange)
        {
            //if (count % 3 == 0)
            //{
            //    for (int i = 0; i < congestionLevel.Length; i++)
            //    {
            //        congestionLevel[i].material.color = Color.red;
            //    }
            //}
            //else if (count % 3 == 1)
            //{
            //    for (int i = 0; i < congestionLevel.Length; i++)
            //    {
            //        congestionLevel[i].material.color = Color.green;
            //    }
            //}
            //else if (count % 3 == 2)
            //{
            //    for (int i = 0; i < congestionLevel.Length; i++)
            //    {
            //        congestionLevel[i].material.color = Color.yellow;
            //    }
            //}

            for (int i = 0; i < congestionLevel.Length; i++)
            {
                congestionLevel[i].material.color = new Color(Random.value, Random.value, Random.value);
            }

            count++;
            timeSinceChange = 0;
        }
    }

    void ChangeColor()
    {
        timeSinceChange += Time.deltaTime;

        if (timeSinceChange >= timeToChange)
        {
            if (count % 3 == 0)
            {
                for (int i = 0; i < congestionLevel.Length; i++)
                {
                    congestionLevel[i].material.color = Color.red;
                }
            }
            else if (count % 3 == 1)
            {
                for (int i = 0; i < congestionLevel.Length; i++)
                {
                    congestionLevel[i].material.color = Color.green;
                }
            }
            else if (count % 3 == 2)
            {
                for (int i = 0; i < congestionLevel.Length; i++)
                {
                    congestionLevel[i].material.color = Color.yellow;
                }
            }

            count++;
            timeSinceChange = 0;
        }
    }
}
