using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialScript : MonoBehaviour
{

    public GameObject Player_UI_Canvas;

    public GameObject TutorialMenu1;
     public GameObject TutorialMenu2;
     public GameObject TutorialMenu3;
     public GameObject TutorialMenu4;
     public GameObject TutorialMenu5;

     public bool hasBeenDone1;
     public bool hasBeenDone2;
     public bool hasBeenDone3;
     public bool hasBeenDone4;
     public bool hasBeenDone5;

     public bool firstFishingSpot;
     public bool firstFish;
     
    public GameObject tempVal;

    void Start()
    {
      tempVal = null;
      hasBeenDone1 = false;
      hasBeenDone2 = false;
      hasBeenDone3 = false;
      hasBeenDone4 = false;
      firstFishingSpot = false;
      firstFish = false; 
    }
    
     void Update()
    {
        if(!hasBeenDone1 && Time.time >= 5.0f) {
            Debug.Log("rached phase 1");
            tutorialOn(1);
            hasBeenDone1 = true;
        }
       /* if (!hasBeenDone2 && firstFishingSpot && hasBeenDone1) 
        {
            Debug.Log("rached phase 2");
            tutorialOn(2);
            hasBeenDone2 = true;
        }
        if (!hasBeenDone3 && firstFish && hasBeenDone2)
        {
            Debug.Log("rached phase 3");
            tutorialOn(3);
            hasBeenDone3 = true;
        }
        if (!hasBeenDone4 && hasBeenDone3)
        {
            tutorialOn(4);
            hasBeenDone4 = true;
        }
        if (!hasBeenDone5 && hasBeenDone4)
        {
            tutorialOn(5);
            hasBeenDone4 = true;
        } */
    }
    
    public void tutorialOn(int tutorialNumber)
    {
        switch (tutorialNumber) {
            case 1:
                tempVal = TutorialMenu1;
                break;
            case 2:
                tempVal = TutorialMenu2;
                break;
            case 3:
                tempVal = TutorialMenu3;
                break;
            case 4:
                tempVal = TutorialMenu4;
                break;
            case 5:
                tempVal = TutorialMenu5;
                break;
            default:
                tempVal = TutorialMenu5;
                break; 
        }
            tempVal.SetActive(true);
            Player_UI_Canvas.SetActive(false);
            Time.timeScale = 0f;
    }

    public void tutorialOff()
    {
        TutorialMenu1.SetActive(false);
        TutorialMenu2.SetActive(false);
        TutorialMenu3.SetActive(false);
        TutorialMenu4.SetActive(false);
        TutorialMenu5.SetActive(false);
        Time.timeScale = 1f;
        Invoke("enableUI", 1); //Loads in the UI after a 1 second delay.
    }
        public void enableUI()
    {
        Player_UI_Canvas.SetActive(true);
    }


}
