using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointPro : MonoBehaviour
{
    public GameObject[] tempArr;

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
    
    //Shing Yip Street
    public GameObject[] SYS_SecondSection_Slow;
    public GameObject[] SYS_SecondSection_Middle;
    public GameObject[] SYS_SecondSection_Fast;
    
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
    
    //Hing Yip Street
    public GameObject[] HYS_FirstSection_Entrance;
    public GameObject[] HYS_FirstSection_Slow;
    public GameObject[] HYS_FirstSection_Middle;
    public GameObject[] HYS_FirstSection_Fast;
    
    public GameObject[] HYS_SecondSection_Slow;
    public GameObject[] HYS_SecondSection_Middle;
    public GameObject[] HYS_SecondSection_Fast;
    public GameObject[] HYS_SecondSection_Exit;
    
    //King Yip Street
    public GameObject[] KYS_ThirdSection_Slow;
    public GameObject[] KYS_ThirdSection_Fast;
    
    public GameObject[] KYS_FourthSection_Slow;
    public GameObject[] KYS_FourthSection_MiddleSlow;
    public GameObject[] KYS_FourthSection_MiddleFast;
    public GameObject[] KYS_FourthSection_Fast;

    public float y = 6;

    private void Start()
    {
        tempArr = GameObject.FindGameObjectsWithTag("HYRFirstSl");

        //Hoi Yuen Road
        HYR_FirstSection_Slow = GameObject.FindGameObjectsWithTag("HYRFirstSl");
        HYR_FirstSection_Middle = GameObject.FindGameObjectsWithTag("HYRFirstMd");
        HYR_FirstSection_Fast = GameObject.FindGameObjectsWithTag("HYRFirstFt");
       
        HYR_SecondSection_Slow = GameObject.FindGameObjectsWithTag("HYRSecSl");
        HYR_SecondSection_Middle = GameObject.FindGameObjectsWithTag("HYRSecMd");
        HYR_SecondSection_Fast = GameObject.FindGameObjectsWithTag("HYRSecFt");

        HYR_ThirdSection_Slow = GameObject.FindGameObjectsWithTag("HYRThirdSl");
        HYR_ThirdSection_Middle = GameObject.FindGameObjectsWithTag("HYRThirdMd");
        HYR_ThirdSection_Fast = GameObject.FindGameObjectsWithTag("HYRThirdFt");
        
        HYR_FourthSection_Slow = GameObject.FindGameObjectsWithTag("HYRFourthSl");
        HYR_FourthSection_Middle = GameObject.FindGameObjectsWithTag("HYRFourthMd");
        HYR_FourthSection_Fast = GameObject.FindGameObjectsWithTag("HYRFourthFt");

        //Shing Yip Street
        SYS_SecondSection_Slow = GameObject.FindGameObjectsWithTag("SYSSecSl");
        SYS_SecondSection_Middle = GameObject.FindGameObjectsWithTag("SYSSecMd");
        SYS_SecondSection_Fast = GameObject.FindGameObjectsWithTag("SYSSecFt");

        SYS_ThirdSection_Slow = GameObject.FindGameObjectsWithTag("SYSThirdSl");
        SYS_ThirdSection_Middle = GameObject.FindGameObjectsWithTag("SYSThirdMd");
        SYS_ThirdSection_Fast = GameObject.FindGameObjectsWithTag("SYSThirdFt");

        SYS_FourthSection_Slow = GameObject.FindGameObjectsWithTag("SYSFourthSl");
        SYS_FourthSection_Middle = GameObject.FindGameObjectsWithTag("SYSFourthMd");
        SYS_FourthSection_Fast = GameObject.FindGameObjectsWithTag("SYSFourthFt");

        //How Ming Street
        HMS_FirstSection_Entrance = GameObject.FindGameObjectsWithTag("HMSFirstEn");
        HMS_FirstSection_Slow = GameObject.FindGameObjectsWithTag("HMSFirstSl");
        HMS_FirstSection_Middle = GameObject.FindGameObjectsWithTag("HMSFirstMd");
        HMS_FirstSection_Fast = GameObject.FindGameObjectsWithTag("HMSFirstFt");

        //Hing Yip Street
        HYS_FirstSection_Entrance = GameObject.FindGameObjectsWithTag("HYSFirstEn");
        HYS_FirstSection_Slow = GameObject.FindGameObjectsWithTag("HYSFirstSl");
        HYS_FirstSection_Middle = GameObject.FindGameObjectsWithTag("HYSFirstMd");
        HYS_FirstSection_Fast = GameObject.FindGameObjectsWithTag("HYSFirstFt");

        HYS_SecondSection_Slow = GameObject.FindGameObjectsWithTag("HYSSecSl");
        HYS_SecondSection_Middle = GameObject.FindGameObjectsWithTag("HYSSecMd");
        HYS_SecondSection_Fast = GameObject.FindGameObjectsWithTag("HYSSecFt");
        HYS_SecondSection_Exit = GameObject.FindGameObjectsWithTag("HYSSecEx");

        //King Yip Street
        KYS_ThirdSection_Slow = GameObject.FindGameObjectsWithTag("KYSThirdSl");
        KYS_ThirdSection_Fast = GameObject.FindGameObjectsWithTag("KYSThirdFt");
        
        KYS_FourthSection_Slow = GameObject.FindGameObjectsWithTag("KYSFourthSl");
        KYS_FourthSection_MiddleSlow = GameObject.FindGameObjectsWithTag("KYSFourthMS");
        KYS_FourthSection_MiddleFast = GameObject.FindGameObjectsWithTag("KYSFourthMF");
        KYS_FourthSection_Fast = GameObject.FindGameObjectsWithTag("KYSFourthFt");


    }

    public GameObject[] GetHYR_FS_Slow()
    {
        return HYR_FirstSection_Slow;
    }
    public GameObject[] GetHYR_FS_Middle()
    {
        return HYR_FirstSection_Middle;
    }
    
    public GameObject[] GetHYR_FS_Fast()
    {
        return HYR_FirstSection_Fast;
    }

    public GameObject[] GetHYR_SS_Slow()
    {
        return HYR_SecondSection_Slow;
    }

    public GameObject[] GetHYR_SS_Middle()
    {
        return HYR_SecondSection_Middle;
    }

    public GameObject[] GetHYR_SS_Fast()
    {
        return HYR_SecondSection_Fast;
    }
}
