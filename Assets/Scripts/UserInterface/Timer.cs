using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        text.text = timer.ToString("00.00's'");
        /*if (timer > 0)
        {
            timer -= Time.deltaTime;
            text.text = timer.ToString("00.00's'");
        }
        else
        {
            Time.timeScale = 0;
        }*/
        
        //text.text = time.ToString("00.00's'");
        //text.text = Mathf.Ceil(time).ToString();
    }
}
