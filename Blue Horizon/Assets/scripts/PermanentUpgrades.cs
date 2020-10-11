using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermanentUpgrades : MonoBehaviour
{
    public static float permanentSpeedBoost;
    public static float permanentCatchBoost;
    public static float asdasd;
    private GameObject fishArray;
    void Start()
    {
        permanentSpeedBoost = 0;
        permanentCatchBoost = 0;
        fishArray=GameObject.Find("Fish Objects");

    }

   
    void Update()
    {
        
    }
    public void IncreasePermanentSpeed()
    {
        permanentSpeedBoost += 3;
    }
    public void IncreasePermanentCatchRate()
    {
        permanentCatchBoost += 1;
    }

    public float ReturnPercentage(float value)
    {
        float finalresult = value + permanentCatchBoost;
        if (finalresult > 1)
            finalresult = 1;
        Debug.Log("score: "+value+" boost: "+permanentCatchBoost+" final result: " + finalresult);
       
        return finalresult;

    }

}
