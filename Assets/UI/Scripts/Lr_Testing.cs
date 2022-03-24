using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lr_Testing : MonoBehaviour
{
    [SerializeField] public LineController hoiYeunRoad;
    [SerializeField] public Transform[] hyr_points;

    [SerializeField] public LineController shingYipStreet;
    [SerializeField] public Transform[] sys_points;

    [SerializeField] public LineController hingYipStreet;
    [SerializeField] public Transform[] hys_points;

    [SerializeField] public LineController howMingStreet;
    [SerializeField] public Transform[] hms_points;
    // Start is called before the first frame update
    void Start()
    {
        hoiYeunRoad.SetUpLine(hyr_points);
        shingYipStreet.SetUpLine(sys_points);
        hingYipStreet.SetUpLine(hys_points);
        howMingStreet.SetUpLine(hms_points);
    }
}
