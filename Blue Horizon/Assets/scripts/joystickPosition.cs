using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Screen.width * 0.85f;
        float y = Screen.width * 0.15f;
        gameObject.transform.SetPositionAndRotation(new Vector3(x,y,0),Quaternion.identity );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
