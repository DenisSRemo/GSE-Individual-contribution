using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkTouch : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    private Collider2D reddot;
    private Collider2D beat;
    void OnEnable()
    {
        score = 0; 
    }

    private void Start()
    {
        reddot = gameObject.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.touchCount == 1)
        {     
            // touch on screen
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (reddot.IsTouching(beat))
                {
                    SoundManagerScript.PlaySound("beatSuccess");
                    Debug.Log("touch");
                    score++;
                    Destroy(beat.gameObject);
                }

            }
            

        }
        else if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("ms");
            if (beat != null)
            {
                if (reddot.IsTouching(beat))
                {
                    SoundManagerScript.PlaySound("beatSuccess");
                    Debug.Log("touch");
                    score++;
                    Destroy(beat.gameObject);
                }
            }
            
        }

    }

    void OnTriggerStay2D(Collider2D col)
    {

        beat = col;

    }
   
}


//if (Input.GetMouseButtonDown(0))
//{
//SoundManagerScript.PlaySound("beatSuccess");
//Debug.Log("touch");
//score++;
//Destroy(col.gameObject);

//}