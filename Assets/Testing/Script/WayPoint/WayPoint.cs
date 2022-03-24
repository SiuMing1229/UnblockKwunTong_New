using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public GameObject[] emptyPath;

    //Hoi Yuen Road
    public GameObject[] HYR_FirstSection_Slow;
    public GameObject[] HYR_FirstSection_Middle;
    public GameObject[] HYR_FirstSection_Fast;

    public GameObject[] HYR_SecondSection_Slow;
    public GameObject[] HYR_SecondSection_Middle;
    public GameObject[] HYR_SecondSection_Fast;

    public GameObject[] HYR_ThirdSection_Slow;
    public GameObject[] HYR_ThirdSection_Middle;
    public GameObject[] HYR_ThirdSection_Fast;

    public GameObject[] HYR_FourthSection_Slow;
    public GameObject[] HYR_FourthSection_Middle;
    public GameObject[] HYR_FourthSection_Fast;
    
    public GameObject[] HYR_FifthSection_Slow;
    public GameObject[] HYR_FifthSection_Middle;
    public GameObject[] HYR_FifthSection_Fast;

    //Shing Yip Street
    public GameObject[] SYS_SecondSection_Slow;
    public GameObject[] SYS_SecondSection_Middle;
    public GameObject[] SYS_SecondSection_Fast;

    public GameObject[] SYS_ThirdSection_Entrance;
    public GameObject[] SYS_ThirdSection_Slow;
    public GameObject[] SYS_ThirdSection_Middle;
    public GameObject[] SYS_ThirdSection_Fast;

    public GameObject[] SYS_FourthSection_Slow;
    public GameObject[] SYS_FourthSection_Middle;
    public GameObject[] SYS_FourthSection_Fast;

    //How Ming Street
    public GameObject[] HMS_FirstSection_Entrance;
    public GameObject[] HMS_FirstSection_Slow;
    public GameObject[] HMS_FirstSection_Middle;
    public GameObject[] HMS_FirstSection_Fast;
   
    public GameObject[] HMS_SecondSection_Slow;
    public GameObject[] HMS_SecondSection_Middle;
    public GameObject[] HMS_SecondSection_Fast;
    
    public GameObject[] HMS_ThirdSection_Slow;
    public GameObject[] HMS_ThirdSection_Middle;

    //Hing Yip Street
    public GameObject[] HYS_FirstSection_Entrance;
    public GameObject[] HYS_FirstSection_Slow;
    public GameObject[] HYS_FirstSection_Middle;
    public GameObject[] HYS_FirstSection_Fast;

    public GameObject[] HYS_SecondSection_EntranceS;
    public GameObject[] HYS_SecondSection_EntranceM;
    public GameObject[] HYS_SecondSection_Slow;
    public GameObject[] HYS_SecondSection_Middle;
    public GameObject[] HYS_SecondSection_Fast;
    public GameObject[] HYS_SecondSection_Exit;

    //King Yip Street
    public GameObject[] KYS_FirstSection_Slow;
    public GameObject[] KYS_FirstSection_Middle;

    public GameObject[] KYS_SecondSection_Slow;
    public GameObject[] KYS_SecondSection_Middle;

    public GameObject[] KYS_ThirdSection_Slow;
    public GameObject[] KYS_ThirdSection_Middle;

    public GameObject[] KYS_FourthSection_Slow;
    public GameObject[] KYS_FourthSection_Middle;
    public GameObject[] KYS_FourthSection_Fast;
    public GameObject[] KYS_FourthSection_Extra;

    //Hung To Road
    public GameObject[] HTR_ThirdSection_Slow;
    public GameObject[] HTR_ThirdSection_Middle;
    public GameObject[] HTR_ThirdSection_Fast;

    public GameObject[] HTR_FourthSection_Entrance;
    public GameObject[] HTR_FourthSection_Slow;
    public GameObject[] HTR_FourthSection_Middle;
    public GameObject[] HTR_FourthSection_Fast;
    
    public GameObject[] HTR_FifthSection_Slow;
    public GameObject[] HTR_FifthSection_Middle;

    //Tsun Yip Street
    public GameObject[] TYS_FirstSection_Slow;
    public GameObject[] TYS_FirstSection_Middle;
    public GameObject[] TYS_FirstSection_Fast;
    
    public GameObject[] TYS_SecondSection_Slow;
    public GameObject[] TYS_SecondSection_Middle;
    public GameObject[] TYS_SecondSection_Fast;
    
    public GameObject[] TYS_ThirdSection_Slow;
    public GameObject[] TYS_ThirdSection_Middle;
    public GameObject[] TYS_ThirdSection_Fast;
    
    public GameObject[] TYS_FourthSection_Slow;
    public GameObject[] TYS_FourthSection_Middle;
    public GameObject[] TYS_FourthSection_Fast;
    
    public GameObject[] TYS_FifthSection_Slow;
    public GameObject[] TYS_FifthSection_Middle;
    public GameObject[] TYS_FifthSection_Fast;

    // Wai Yip Street

    //Roundabout
    public GameObject[] WYS_RA_FirstSection_Slow;
    public GameObject[] WYS_RA_FirstSection_Middle;
    public GameObject[] WYS_RA_FirstSection_Fast;
    public GameObject[] WYS_RA_FirstSection_Exit;
    
    public GameObject[] WYS_RA_SecondSection_Slow;
    public GameObject[] WYS_RA_SecondSection_Middle;
    
    public GameObject[] WYS_RA_ThirdSection_Slow;
    public GameObject[] WYS_RA_ThirdSection_Middle;
    
    public GameObject[] WYS_RA_FourthSection_Slow;
    public GameObject[] WYS_RA_FourthSection_Middle;
    
    public GameObject[] WYS_RA_FifthSection_Slow;
    public GameObject[] WYS_RA_FifthSection_Middle;

    public GameObject[] WYS_RA_SixthEntrance_Entrance;
    public GameObject[] WYS_RA_SixthSection_Slow;
    public GameObject[] WYS_RA_SixthSection_Middle;
    public GameObject[] WYS_RA_SixthSection_Fast;

    public GameObject[] WYS_RA_SeventhSection_Slow;
    public GameObject[] WYS_RA_SeventhSection_Middle;
    public GameObject[] WYS_RA_SeventhSection_Fast;

    public GameObject[] WYS_FF_FirstSection_Slow;
    public GameObject[] WYS_FF_FirstSection_Middle;
    public GameObject[] WYS_FF_SecondSection_Slow;
    public GameObject[] WYS_FF_SecondSection_Middle;
    public GameObject[] WYS_FF_ThirdSection_Slow;
    public GameObject[] WYS_FF_ThirdSection_Middle;
    public GameObject[] WYS_FF_ThirdSection_Fast;
    //public GameObject[] WYS_FF_FourthSection_Slow;
    //public GameObject[] WYS_FF_FourthSection_Middle;
    //public GameObject[] WYS_FF_FourthSection_Fast;

    //public GameObject[] WYS_TF_FirstSection_Slow;
    //public GameObject[] WYS_TF_FirstSection_Middle;
    //public GameObject[] WYS_TF_ThirdSection_Slow;
    //public GameObject[] WYS_TF_ThirdSection_Middle;
    //public GameObject[] WYS_TF_ThirdSection_Fast;
    public GameObject[] WYS_TF_SeventhSection_Slow;
    public GameObject[] WYS_TF_SeventhSection_Middle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
