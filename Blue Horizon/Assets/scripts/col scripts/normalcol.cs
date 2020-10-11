using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalcol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Application.persistentDataPath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
     
       if(other.tag=="Player")
       {
           PlayerStats.biome = "Normal";
       }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerStats.TimeSpentInNormal += 1 * Time.deltaTime;
        }

    }
}
