using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xdsfjkuhysdf : MonoBehaviour
{
    public int aa = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1)
        {    
            // touch on screen
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                SoundManagerScript.PlaySound("beatSuccess");

            }

        }
        
    }
}
