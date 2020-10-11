using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twilightcol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            PlayerStats.biome = "Twilight";
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerStats.TimeSpentInTwilight += 1 * Time.deltaTime;
        }

    }
}
