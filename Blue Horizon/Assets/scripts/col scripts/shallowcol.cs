using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shallowcol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            PlayerStats.biome = "Shallow";
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerStats.TimeSpentInShallow += 1 * Time.deltaTime;
        }

    }


}
