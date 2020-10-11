using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mountaincol : MonoBehaviour
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
            PlayerStats.biome = "Mountainous";
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerStats.TimeSpentInMountain += 1 * Time.deltaTime;
        }

    }


}
