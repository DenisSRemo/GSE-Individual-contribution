using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lanching_ball : MonoBehaviour
{

    public GameObject ball;
    public Button Lanch_button;
    public Slider Power;
    public InputField Angle;
    public string str;
    public float pr;
    public Rigidbody rb;
   private float xcomponent;
    private float ycomponent;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        str = Angle.text;
        pr = Power.value;
    }

    // Update is called once per frame
    void Update()
    {
        str = Angle.text;
        pr = Power.value*20;
        xcomponent = Mathf.Cos(float.Parse(str) * Mathf.PI / 180) * pr;
         ycomponent = Mathf.Sin(float.Parse(str) * Mathf.PI / 180) * pr;
    }

    public void Launch()
    {
        rb.AddForce(ycomponent, 0, xcomponent);
    }
}
