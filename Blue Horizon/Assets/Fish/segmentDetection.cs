using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segmentDetection : MonoBehaviour
{
    private GameObject FishList;
    public int numberOfSegmentsUnlocked;

    // Start is called before the first frame update
    void Start()
    {
        FishList = GameObject.Find("Fish Objects");
        fishValues fishVal = FishList.GetComponent<fishValues>();
        fishArray fishArr = FishList.GetComponent<fishArray>();

        Debug.Log(checkForSegments());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int checkForSegments() {

        int numberOfSegments = checkBiomeForSegments(fishArray.NormalFish) + checkBiomeForSegments(fishArray.TundraFish) + checkBiomeForSegments(fishArray.MountainousFish) + checkBiomeForSegments(fishArray.SwampFish) + checkBiomeForSegments(fishArray.ShallowFish) + checkBiomeForSegments(fishArray.TwilightFish) + checkBiomeForSegments(fishArray.SunsetFish);
        return numberOfSegments;

    }

    public int checkBiomeForSegments(fish[] arrayToCheck)
    {
        int tempNumOfSegs = 0;

        bool commonSegment = true;
        bool uncommonSegment = true;
        bool rareSegment = true;
        bool endangeredSegment = true;
        bool undiscoveredSegment = true;

        for (int x = 0; x < 21; x++) {

            fish tempObject = arrayToCheck[x];

            if (arrayToCheck[x].FishIsOwned == false)
            {
                if (x >= 0 && x < 10)
                {
                    commonSegment = false;
                }
                if (x >= 10 && x < 15)
                {
                    uncommonSegment = false;
                }
                if (x >= 15 && x < 18)
                {
                    rareSegment = false;
                }
                if (x >= 18 && x < 20)
                {
                    endangeredSegment = false;
                }
                if (x == 20)
                {
                    undiscoveredSegment = false;
                }
            }
                if (commonSegment)
                {
                    tempNumOfSegs++;
                }
                if (uncommonSegment)
                {
                    tempNumOfSegs++;
                }
                if (rareSegment)
                {
                    tempNumOfSegs++;
                }
                if (endangeredSegment)
                {
                    tempNumOfSegs++;
                }
                if (undiscoveredSegment)
                {
                    tempNumOfSegs++;
                }
        }

        return tempNumOfSegs;

    }
}
