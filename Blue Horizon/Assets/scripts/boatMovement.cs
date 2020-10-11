using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatMovement : MonoBehaviour
{
    public Joystick joystick;

    public float sailSpeed;
    public double boost;
    public float TimedBonusSpeed;
    // Start is called before the first frame update
    void Start()
    {
        boost = 0.01f;

    }
    float velocity;
    Vector3 previous;
    private void Update()
    {
        velocity = ((transform.position - previous).magnitude) / Time.deltaTime;
        previous = transform.position;
       // Debug.Log(velocity);
   

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (joystick.Horizontal >= 0.3f)
        {
         
            gameObject.transform.Rotate(new Vector3(0, 1, 0), 1);
            boost -= 0.3 * Time.deltaTime;

        }

        if (joystick.Horizontal <= -0.3f)
        {
         

            gameObject.transform.Rotate(new Vector3(0, 1, 0), -1);
            boost -= 0.3 * Time.deltaTime;


        }

        if (joystick.Vertical == 0)
        {
            if (boost > 0.1)
                boost -= 0.3 * Time.deltaTime;
        }
        if (joystick.Vertical <= -0.3f)
        {
           
            if(boost<0.99)
                boost += 0.3 * Time.deltaTime;
            Vector3 movement = gameObject.transform.rotation * Vector3.back*(sailSpeed/2*(float)boost)+ transform.position;
            gameObject.GetComponent<Rigidbody>().MovePosition(movement);

        }
        if (joystick.Vertical >= 0.3f)
        {
          
            if(boost<0.99)
                boost += 0.3 * Time.deltaTime;


            Vector3 movement = gameObject.transform.rotation * Vector3.forward*sailSpeed*(float)boost + transform.position;
            gameObject.GetComponent<Rigidbody>().MovePosition(movement);

        }


   

    }
}
