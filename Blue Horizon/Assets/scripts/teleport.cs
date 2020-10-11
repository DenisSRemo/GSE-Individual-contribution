using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class teleport : MonoBehaviour
{
    GameObject player;
    public GameObject popUp;
    public GameObject lockedBiomePopUp;

    public bool popUpActive;

    public string clickedBiomestring;
    public GameObject clickedBiomeobject;

   public GameObject normalcenter;
   public GameObject tundracenter;
   public GameObject twilightcenter;
   public GameObject swampcenter;
   public GameObject mountaincenter;
   public GameObject shallowcenter;
   public GameObject sunrisecenter;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        popUpActive = false;
        clickedBiomestring = "";
       // normalcenter.transform.position.y -= 99;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopUpToggle(string tempBiome)
    {
        if (tempBiome != null)
        {
            clickedBiomestring = tempBiome;
        }
        popUpActive = !popUpActive;
        popUp.SetActive(popUpActive);
    }

    public void PressedYes()
    {
        player.transform.SetPositionAndRotation(stringToGameObject(clickedBiomestring).transform.position, Quaternion.identity);
        PopUpToggle("");
    }

    public void PressedNo()
    {
        PopUpToggle("");
    }

    public GameObject stringToGameObject(string clickedBiomestring) {
        switch (clickedBiomestring)
        {
            case "normalcenter":
                return normalcenter;
            case "tundracenter":
                return tundracenter;
            case "twilightcenter":
                return twilightcenter;
            case "swampcenter":
                return swampcenter;
            case "sunrisecenter":
                return sunrisecenter;
            case "shallowcenter":
                return shallowcenter;
            case "mountaincenter":
                return mountaincenter;
            default:
                return normalcenter;
        }
    }

    IEnumerator lockedBiomePopUpCode() {
        lockedBiomePopUp.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        lockedBiomePopUp.SetActive(false);

    }


    public void TPNormal()
    {

        if (wallRemover.unlockedBiomes.Contains(0))
        {
            Debug.Log("now normal");
            PopUpToggle("normalcenter");
            //player.transform.SetPositionAndRotation(normalcenter.transform.position,Quaternion.identity );
        } else lockedBiomePopUpCode();
    }
    public void TPTwilight()
    {
        if (wallRemover.unlockedBiomes.Contains(1))
        {
            Debug.Log("now twilight");
            PopUpToggle("twilightcenter");
            //player.transform.SetPositionAndRotation(twilightcenter.transform.position,Quaternion.identity );
        } else lockedBiomePopUpCode();
    }
    public void TPTundra()
    {
        if (wallRemover.unlockedBiomes.Contains(4))
        {
            Debug.Log("now tundra");
            PopUpToggle("tundracenter");
            //player.transform.SetPositionAndRotation(tundracenter.transform.position,Quaternion.identity );
        } else lockedBiomePopUpCode();
    }

    
    public void TPSwamp()
    {
        if (wallRemover.unlockedBiomes.Contains(6))
        {
            Debug.Log("now swamp");
            PopUpToggle("swampcenter");
           // player.transform.SetPositionAndRotation(swampcenter.transform.position,Quaternion.identity );
        } else lockedBiomePopUpCode();
    }
    public void TPMountain()
    {
        if (wallRemover.unlockedBiomes.Contains(5))
        {
            Debug.Log("now mountain");
            PopUpToggle("mountaincenter");
            //player.transform.SetPositionAndRotation(mountaincenter.transform.position,Quaternion.identity );
        } else lockedBiomePopUpCode();
    }
    public void TPShallow()
    {
        if (wallRemover.unlockedBiomes.Contains(2))
        {
            Debug.Log("now shallow");
            PopUpToggle("shallowcenter");
            //player.transform.SetPositionAndRotation(shallowcenter.transform.position,Quaternion.identity );
        } else lockedBiomePopUpCode();
    }
    public void TPSunrise()
    {
        if (wallRemover.unlockedBiomes.Contains(3))
        {
            Debug.Log("now sunrise");
            PopUpToggle("sunrisecenter");
            //player.transform.SetPositionAndRotation(sunrisecenter.transform.position,Quaternion.identity );
        } else lockedBiomePopUpCode();
    }
}
