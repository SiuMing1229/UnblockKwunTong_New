using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrafficDetail : MonoBehaviour
{
    public GameObject panel;
    public void OpenPanel()
    {
        Debug.Log("clicked");
        if(panel != null)
        {
            bool isActive = panel.activeSelf;

            panel.SetActive(!isActive);
        }
    }
}
