using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBeats : MonoBehaviour
{
    public float speed = 2.0f;
    private GameObject check;

    // Start is called before the first frame update
    void Start()
    {
        check=GameObject.Find("Check");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * speed * Time.deltaTime;
        if (transform.position.x <= check.transform.position.x-50)
        {
            SoundManagerScript.PlaySound("beatFailure");
            Destroy(gameObject);
        }

    }
}
