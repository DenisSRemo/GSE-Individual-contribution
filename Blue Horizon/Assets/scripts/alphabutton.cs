using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alphabutton : MonoBehaviour
{
    // Start is called before the first frame update
    public float AlphaThreshold = 0.01f;
    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThreshold; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}