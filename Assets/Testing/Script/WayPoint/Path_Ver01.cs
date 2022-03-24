using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path_Ver01 : MonoBehaviour
{
    /*
    WayPoint waypoint;

    public int ID = 0;
    public GameObject[] path;
    public int nextMainPathIndex;
    public int nextPathIndex;
    public int[] nextMultiPathIndex;

    public Path[] slowPath;
    public Path[] middlePath;
    public Path[] fastPath;

    //Debug use
    public int setPathIndex;
    public int showPathID;
    public GameObject[] showPathArr;

    public Path_Ver01(GameObject[] pathList, int nextMainPathIndex, int nextPathIndex)
    {
        this.path = pathList;
        this.nextMainPathIndex = nextMainPathIndex;
        this.nextPathIndex = nextPathIndex;
    }
    private void Start()
    {
        waypoint = GetComponent<WayPoint>();

        // ----------Slow Path-----------
        slowPath = new Path[100];

        // Hoi Yuen Road
        slowPath[11] = new Path(waypoint.HYR_FirstSection_Slow, 1, 12);
        slowPath[12] = new Path(waypoint.HYR_SecondSection_Slow, 1, 13);
        slowPath[13] = new Path(waypoint.HYR_ThirdSection_Slow, 1, 30);
        slowPath[14] = new Path(waypoint.HYR_FourthSection_Slow, 1, 60);

        //SYS
        slowPath[22] = new Path(waypoint.SYS_SecondSection_Slow, 1, 23);
        slowPath[23] = new Path(waypoint.SYS_ThirdSection_Slow, 1, 24);
        slowPath[24] = new Path(waypoint.SYS_FourthSection_Slow, 1, 12);

        //HYS
        slowPath[30] = new Path(waypoint.HYS_FirstSection_Entrance, 1, 31);
        slowPath[31] = new Path(waypoint.HYS_FirstSection_Slow, 1, 32);
        slowPath[32] = new Path(waypoint.HYS_SecondSection_Slow, 1, 33);
        slowPath[33] = new Path(waypoint.HYS_SecondSection_Exit, 1, 43);

        //King Yip Street
        //slowPath[41] = new Path(waypoint.KYS_FirstSection_Slow, 1, 42);
        slowPath[42] = new Path(waypoint.KYS_SecondSection_Slow, 1, 43);
        slowPath[43] = new Path(waypoint.KYS_ThirdSection_Slow, 1, 44);
        slowPath[44] = new Path(waypoint.KYS_FourthSection_Slow, 1, 22);

        //Hung To Road
        slowPath[60] = new Path(waypoint.HTR_FourthSection_Entrance, 2, 61);
        slowPath[61] = new Path(waypoint.HTR_FourthSection_Slow, 2, 60);

        // -----------Middle Path----------
        middlePath = new Path[100];
        middlePath[0] = null;

        //Hoi Yuen Road
        middlePath[11] = new Path(waypoint.HYR_FirstSection_Middle, 2, 12);
        middlePath[12] = new Path(waypoint.HYR_SecondSection_Middle, 2, 13);
        middlePath[13] = new Path(waypoint.HYR_ThirdSection_Middle, 2, 14);
        middlePath[14] = new Path(waypoint.HYR_FourthSection_Middle, 2, 0);

        //Shing Yip Street
        middlePath[22] = new Path(waypoint.SYS_SecondSection_Middle, 2, 23);
        middlePath[23] = new Path(waypoint.SYS_ThirdSection_Middle, 2, 24);
        middlePath[24] = new Path(waypoint.SYS_ThirdSection_Middle, 2, 0);

        //Hing Yip Street
        //middlePath[30] = new Path(waypoint.HYS_FirstSection_Entrance, 31);
        middlePath[31] = new Path(waypoint.HYS_FirstSection_Middle, 2, 32);
        middlePath[32] = new Path(waypoint.HYS_SecondSection_Middle, 2, 0);
        middlePath[33] = new Path(waypoint.HYS_SecondSection_Exit, 2, 41);

        //Hung To Road
        middlePath[61] = new Path(waypoint.HTR_FourthSection_Middle, 1, 42);


        // ----------Fast Path----------
        fastPath = new Path[100];
        fastPath[0] = null;
        // Hoi Yuen Road
        fastPath[11] = new Path(waypoint.HYR_FirstSection_Fast, 3, 12);
        fastPath[12] = new Path(waypoint.HYR_SecondSection_Fast, 3, 13);
        fastPath[13] = new Path(waypoint.HYR_ThirdSection_Fast, 3, 14);
        fastPath[14] = new Path(waypoint.HYR_FourthSection_Fast, 3, 0);

        //How Ming Street
        fastPath[50] = new Path(waypoint.HMS_FirstSection_Entrance, 3, 51);
        fastPath[51] = new Path(waypoint.HMS_FirstSection_Fast, 3, 52);

        // 

    }

    private void Update()
    {
        showPathID = slowPath[setPathIndex].ID;
        showPathArr = slowPath[setPathIndex].path;
    }
    public Path_Ver01(int ID, GameObject[] pathList, int[] nextMultiPathIndex)
    {
        this.ID = ID;
        this.path = pathList;
        this.nextMultiPathIndex = nextMultiPathIndex;
    }

    public GameObject[] GetPath(int mainIndex, int pathIndex)
    {
        if (mainIndex == 1)
        {
            return slowPath[pathIndex].path;
        }
        else if (mainIndex == 2)
        {
            return middlePath[pathIndex].path;
        }
        else if (mainIndex == 3)
        {
            return fastPath[pathIndex].path;
        }
        else
        {
            return null;
        }
    }

    public int GetNextPathID(int currentMainIndex, int pathIndex)
    {
        if (currentMainIndex == 1)
        {
            return slowPath[pathIndex].nextPathIndex;
        }
        else if (currentMainIndex == 2)
        {
            return middlePath[pathIndex].nextPathIndex;
        }
        else if (currentMainIndex == 3)
        {
            return fastPath[pathIndex].nextPathIndex;
        }
        else
        {
            return 0;
        }
    }

    public int GetNextMainPathIndex(int mainIndex, int pathIndex)
    {
        if (mainIndex == 1)
        {
            return slowPath[pathIndex].nextMainPathIndex;
        }
        else if (mainIndex == 2)
        {
            return middlePath[pathIndex].nextMainPathIndex;
        }
        else if (mainIndex == 3)
        {
            return fastPath[pathIndex].nextMainPathIndex;
        }
        else
        {
            return 0;
        }
    }*/

}
