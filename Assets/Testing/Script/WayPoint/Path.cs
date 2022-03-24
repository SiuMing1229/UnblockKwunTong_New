using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Path : MonoBehaviour
{
    WayPoint waypoint;

    public int ID = 0;
    public GameObject[] path;
    public GameObject[] emptyPath;
    public int nextMainPathIndex;
    public int nextPathIndex;
    public int secondPathIndex;
    private int maxPathNum;

    public Path[] slowPath;
    public Path[] middlePath;
    public Path[] fastPath;
    public Path[] extraPath;
    public Path[] roundAbout;
    
    //Debug use
    public int setPathIndex;
    //public int showPathID;
    //public GameObject[] showPathArr; 

    public Path(GameObject[] pathList,int nextMainPathIndex, int nextPathIndex, int secondPathIndex)
    {
        this.path = pathList;
        this.nextMainPathIndex = nextMainPathIndex;
        this.nextPathIndex = nextPathIndex;
        this.secondPathIndex = secondPathIndex;
    }
    private void Start()
    {
        maxPathNum = 200;
        waypoint = GetComponent<WayPoint>();

        // ----------Slow Path-----------
        slowPath = new Path[maxPathNum];
        slowPath[9] = new Path(waypoint.emptyPath, 0, 0, 0);

        // Hoi Yuen Road
        slowPath[11] = new Path(waypoint.HYR_FirstSection_Slow, 1, 12, 0);
        slowPath[12] = new Path(waypoint.HYR_SecondSection_Slow, 1, 13, 0);
        slowPath[13] = new Path(waypoint.HYR_ThirdSection_Slow, 1, 14, 30);
        slowPath[14] = new Path(waypoint.HYR_FourthSection_Slow, 1, 15, 60);
        slowPath[15] = new Path(waypoint.HYR_FifthSection_Slow, 1, 81, 0);

        //SYS
        slowPath[22] = new Path(waypoint.SYS_SecondSection_Slow, 1, 23, 0);
        slowPath[23] = new Path(waypoint.SYS_ThirdSection_Slow, 1, 24, 0);
        slowPath[24] = new Path(waypoint.SYS_FourthSection_Slow, 1, 12, 0);
        slowPath[25] = new Path(waypoint.SYS_ThirdSection_Entrance, 1, 23, 0);

        //Hang Yip Street
        slowPath[30] = new Path(waypoint.HYS_FirstSection_Entrance, 10, 31, 0);
        slowPath[31] = new Path(waypoint.HYS_FirstSection_Slow, 1, 32, 0);
        slowPath[32] = new Path(waypoint.HYS_SecondSection_Slow, 2, 33, 0);
        slowPath[34] = new Path(waypoint.HYS_SecondSection_EntranceS, 1, 32, 0);

        //King Yip Street
        slowPath[41] = new Path(waypoint.KYS_FirstSection_Slow, 1, 42, 0);
        slowPath[42] = new Path(waypoint.KYS_SecondSection_Slow, 1, 43, 0);
        slowPath[43] = new Path(waypoint.KYS_ThirdSection_Slow, 12, 44, 0);
        slowPath[44] = new Path(waypoint.KYS_FourthSection_Slow, 1, 22, 0);

        //How Ming Street
        slowPath[51] = new Path(waypoint.HMS_FirstSection_Slow, 1, 52, 0);
        slowPath[52] = new Path(waypoint.HMS_SecondSection_Slow, 1, 53, 0);
        slowPath[53] = new Path(waypoint.HMS_ThirdSection_Slow, 1, 9, 0);

        //Hung To Road
        slowPath[60] = new Path(waypoint.HTR_FourthSection_Entrance, 10, 64, 0);
        slowPath[63] = new Path(waypoint.HTR_ThirdSection_Slow, 1, 64, 15);
        slowPath[64] = new Path(waypoint.HTR_FourthSection_Slow, 1, 65, 0);
        slowPath[65] = new Path(waypoint.HTR_FifthSection_Slow, 1, 42, 0);

        //Tsun Yip Road
        slowPath[71] = new Path(waypoint.TYS_FirstSection_Slow, 1, 72, 0);
        slowPath[72] = new Path(waypoint.TYS_SecondSection_Slow, 1, 73, 0);
        slowPath[73] = new Path(waypoint.TYS_ThirdSection_Slow, 1, 74, 0);
        slowPath[74] = new Path(waypoint.TYS_FourthSection_Slow, 1, 75, 0);
        slowPath[75] = new Path(waypoint.TYS_FifthSection_Slow, 1, 53, 0);

        // Wai Yip Street
        slowPath[81] = new Path(waypoint.WYS_RA_FirstSection_Slow, 1, 101, 0);
        slowPath[82] = new Path(waypoint.WYS_RA_SecondSection_Slow, 1, 83, 0);
        slowPath[83] = new Path(waypoint.WYS_RA_ThirdSection_Slow, 1, 84, 0);
        slowPath[84] = new Path(waypoint.WYS_RA_FourthSection_Slow, 1, 85, 0);
        slowPath[85] = new Path(waypoint.WYS_RA_FifthSection_Slow, 1, 86, 92);
        slowPath[86] = new Path(waypoint.WYS_RA_SixthSection_Slow, 1, 87, 0);
        slowPath[87] = new Path(waypoint.WYS_RA_SeventhSection_Slow, 1, 81, 0);
        slowPath[89] = new Path(waypoint.WYS_RA_FirstSection_Exit, 2, 101, 0);

        slowPath[91] = new Path(waypoint.WYS_FF_FirstSection_Slow, 1, 83, 0);
        slowPath[92] = new Path(waypoint.WYS_FF_SecondSection_Slow, 1, 93, 0);
        slowPath[93] = new Path(waypoint.WYS_FF_ThirdSection_Slow, 1, 9, 0);
        //slowPath[94] = new Path(waypoint.WYS_FF_FourthSection_Slow, 1, 83, 0);

        slowPath[101] = new Path(waypoint.WYS_TF_SeventhSection_Slow, 1, 9, 0);

        // -----------Middle Path----------
        middlePath = new Path[maxPathNum];
        middlePath[0] = null;
        middlePath[9] = new Path(waypoint.emptyPath, 0, 0, 0);

        //Hoi Yuen Road
        middlePath[11] = new Path(waypoint.HYR_FirstSection_Middle, 2, 12, 0);
        middlePath[12] = new Path(waypoint.HYR_SecondSection_Middle, 2, 13, 0);
        middlePath[13] = new Path(waypoint.HYR_ThirdSection_Middle, 2, 14, 0);
        middlePath[14] = new Path(waypoint.HYR_FourthSection_Middle, 2, 15, 0);
        middlePath[15] = new Path(waypoint.HYR_FifthSection_Middle, 2, 81, 0);

        //Shing Yip Street
        middlePath[22] = new Path(waypoint.SYS_SecondSection_Middle, 2, 23, 0);
        middlePath[23] = new Path(waypoint.SYS_ThirdSection_Middle, 2, 24, 0);
        middlePath[24] = new Path(waypoint.SYS_FourthSection_Middle, 2, 12, 0);

        //Hing Yip Street
        middlePath[31] = new Path(waypoint.HYS_FirstSection_Middle, 2, 32, 0);
        middlePath[32] = new Path(waypoint.HYS_SecondSection_Middle, 2, 33, 0);
        middlePath[33] = new Path(waypoint.HYS_SecondSection_Exit, 12, 43, 0);
        middlePath[34] = new Path(waypoint.HYS_SecondSection_EntranceM, 2, 32, 0);

        //King Yip Street
        middlePath[41] = new Path(waypoint.KYS_FirstSection_Middle, 2, 42, 0);
        middlePath[42] = new Path(waypoint.KYS_SecondSection_Middle, 2, 43, 0);
        middlePath[43] = new Path(waypoint.KYS_ThirdSection_Middle, 34, 44, 0);
        middlePath[44] = new Path(waypoint.KYS_FourthSection_Middle, 2, 22, 0);

        //How Ming Street
        middlePath[51] = new Path(waypoint.HMS_FirstSection_Middle, 2, 52, 0);
        middlePath[52] = new Path(waypoint.HMS_SecondSection_Middle, 2, 53, 0);
        middlePath[53] = new Path(waypoint.HMS_ThirdSection_Middle, 2, 9, 0);

        //Hung To Road
        middlePath[63] = new Path(waypoint.HTR_ThirdSection_Middle, 2, 64, 0);
        middlePath[64] = new Path(waypoint.HTR_FourthSection_Middle, 2, 65, 0);
        middlePath[65] = new Path(waypoint.HTR_FifthSection_Middle, 2, 42, 0);

        // Tsun Yip Street
        middlePath[71] = new Path(waypoint.TYS_FirstSection_Middle, 2, 72, 0);
        middlePath[72] = new Path(waypoint.TYS_SecondSection_Middle, 2, 73, 0);
        middlePath[73] = new Path(waypoint.TYS_ThirdSection_Middle, 2, 74, 0);
        middlePath[74] = new Path(waypoint.TYS_FourthSection_Middle, 2, 75, 0);
        middlePath[75] = new Path(waypoint.TYS_FifthSection_Middle, 2, 53, 0);

        // Wai Yip Street
        
        middlePath[81] = new Path(waypoint.WYS_RA_FirstSection_Middle, 1, 82, 89);
        middlePath[82] = new Path(waypoint.WYS_RA_SecondSection_Middle, 2, 83, 0);
        middlePath[83] = new Path(waypoint.WYS_RA_ThirdSection_Middle, 2, 84, 0);
        middlePath[84] = new Path(waypoint.WYS_RA_FourthSection_Middle, 2, 85, 0);
        middlePath[85] = new Path(waypoint.WYS_RA_FifthSection_Middle, 2, 88, 92);
        middlePath[86] = new Path(waypoint.WYS_RA_SixthSection_Middle, 2, 87, 0);
        middlePath[87] = new Path(waypoint.WYS_RA_SeventhSection_Middle, 2, 81, 0);
        middlePath[88] = new Path(waypoint.WYS_RA_SixthEntrance_Entrance, 23, 86, 0);
        

        middlePath[91] = new Path(waypoint.WYS_FF_FirstSection_Middle, 2, 83, 0);
        middlePath[92] = new Path(waypoint.WYS_FF_SecondSection_Middle, 2, 93, 0);
        middlePath[93] = new Path(waypoint.WYS_FF_ThirdSection_Middle, 2, 9, 0);
        //middlePath[94] = new Path(waypoint.WYS_FF_FourthSection_Middle, 2, 9, 0);
        
        middlePath[101] = new Path(waypoint.WYS_TF_SeventhSection_Middle, 2, 9, 0);

        // ----------Fast Path----------
        fastPath = new Path[200];
        fastPath[9] = new Path(waypoint.emptyPath, 0, 0, 0);
        // Hoi Yuen Road
        fastPath[11] = new Path(waypoint.HYR_FirstSection_Fast, 3, 12, 0);
        fastPath[12] = new Path(waypoint.HYR_SecondSection_Fast, 3, 13, 50);
        fastPath[13] = new Path(waypoint.HYR_ThirdSection_Fast, 3, 14, 0);
        fastPath[14] = new Path(waypoint.HYR_FourthSection_Fast, 3, 15, 0);
        fastPath[15] = new Path(waypoint.HYR_FifthSection_Fast, 3, 81, 0);

        //Shing Yip Street
        fastPath[22] = new Path(waypoint.SYS_SecondSection_Fast, 3, 23, 0);
        fastPath[23] = new Path(waypoint.SYS_ThirdSection_Fast, 3, 24, 0);
        fastPath[24] = new Path(waypoint.SYS_FourthSection_Fast, 3, 12, 0);

        //Hing Yip Street
        fastPath[31] = new Path(waypoint.HYS_FirstSection_Fast, 3, 32, 0);
        fastPath[32] = new Path(waypoint.HYS_SecondSection_Fast, 2, 33, 0);

        //King Yip Street
        fastPath[44] = new Path(waypoint.KYS_FourthSection_Fast, 3, 9, 0);

        //How Ming Street
        fastPath[50] = new Path(waypoint.HMS_FirstSection_Entrance, 10, 51, 0);
        fastPath[51] = new Path(waypoint.HMS_FirstSection_Fast, 3, 52, 0);
        fastPath[52] = new Path(waypoint.HMS_SecondSection_Fast, 3, 9, 0);

        // Hung To Road
        fastPath[63] = new Path(waypoint.HTR_ThirdSection_Fast, 3, 64, 0);
        fastPath[64] = new Path(waypoint.HTR_FourthSection_Fast, 2, 65, 0);

        // Tsun Yip Street
        fastPath[71] = new Path(waypoint.TYS_FirstSection_Fast, 3, 72, 0);
        fastPath[72] = new Path(waypoint.TYS_SecondSection_Fast, 3, 73, 0);
        fastPath[73] = new Path(waypoint.TYS_ThirdSection_Fast, 3, 74, 0);
        fastPath[74] = new Path(waypoint.TYS_FourthSection_Fast, 3, 75, 0);
        fastPath[75] = new Path(waypoint.TYS_FifthSection_Fast, 3, 9, 0);

        //Wai Yip Street
        fastPath[81] = new Path(waypoint.WYS_RA_FirstSection_Fast, 2, 82, 0);
        fastPath[86] = new Path(waypoint.WYS_RA_SixthSection_Fast, 3, 87, 0);
        fastPath[87] = new Path(waypoint.WYS_RA_SeventhSection_Fast, 3, 81, 0);

        // ---------- Extra Path -----------
        extraPath = new Path[maxPathNum];
        extraPath[9] = new Path(waypoint.emptyPath, 0, 0, 0);

        //King Yip Street
        extraPath[44] = new Path(waypoint.KYS_FourthSection_Extra, 4, 9, 0);
    }

    private void Update()
    {
        //showPathID = slowPath[setPathIndex].ID;
        //showPathArr = slowPath[setPathIndex].path;
    }

    public GameObject[] GetPath(int mainIndex, int pathIndex)
    {
        if(mainIndex == 1)
        {
            return slowPath[pathIndex].path;
        }
        else if(mainIndex == 2)
        {
            return middlePath[pathIndex].path;
        }
        else if(mainIndex == 3)
        {
            return fastPath[pathIndex].path;
        }
        else if (mainIndex == 4)
        {
            return extraPath[pathIndex].path;
        }
        else
        {
            return null;
        }
    }

    public int GetNextPathID(int currentMainIndex, int pathIndex, int secondPathIndex)
    {
        //float istIndex = Random.Range(0f, 10f);
        if(secondPathIndex == 0)
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
            else if (currentMainIndex == 4)
            {
                return extraPath[pathIndex].nextPathIndex;
            }
            else
            {
                return 0;
            }
        }
        else if(secondPathIndex != 0)
        {
            float ran = Random.Range(0f, 1f);
            if(ran <= 0.4)
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
                else if (currentMainIndex == 4)
                {
                    return extraPath[pathIndex].nextPathIndex;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (currentMainIndex == 1)
                {
                    return slowPath[pathIndex].secondPathIndex;
                }
                else if (currentMainIndex == 2)
                {
                    return middlePath[pathIndex].secondPathIndex;
                }
                else if (currentMainIndex == 3)
                {
                    return fastPath[pathIndex].secondPathIndex;
                }
                else if (currentMainIndex == 4)
                {
                    return extraPath[pathIndex].secondPathIndex;
                }
                else
                {
                    return 0;
                }
            }
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
        else if (mainIndex == 4)
        {
            return extraPath[pathIndex].nextMainPathIndex;
        }
        else
        {
            return 0;
        }
    }

    public int GetSecondPathIndex(int mainIndex, int pathIndex)
    {
        if (mainIndex == 1)
        {
            return slowPath[pathIndex].secondPathIndex;
        }
        else if (mainIndex == 2)
        {
            return middlePath[pathIndex].secondPathIndex;
        }
        else if (mainIndex == 3)
        {
            return fastPath[pathIndex].secondPathIndex;
        }
        else
        {
            return 0;
        }
    }


}
