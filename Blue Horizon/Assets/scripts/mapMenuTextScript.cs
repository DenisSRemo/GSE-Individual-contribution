using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mapMenuTextScript : MonoBehaviour
{

    public GameObject mapMenuText;
    public Text mapMenuTempText;

    // Start is called before the first frame update
    void Start()
    {
        mapMenuTempText.text = "Test"; 
    }

    // Update is called once per frame
    void Update()
    {
        mapMenuText.GetComponent<Text>().text = mapMenuTempText.text;
    }
}
