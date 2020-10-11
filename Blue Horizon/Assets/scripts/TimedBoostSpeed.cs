using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimedBoostSpeed : MonoBehaviour
{

    public TextMeshProUGUI SpeedBoost;
    public float boostTime;
    public float boostammount;
    // Start is called before the first frame update
    void Start()
    {
        boostammount = 1;   
    }
   

    // Update is called once per frame
    void Update()
    {
        SpeedBoost.text = "Speed Boost Time: " + boostTime + " power: " + boostammount;
        if (boostTime > 0)
            boostTime -= 1.6f * Time.deltaTime;
        if (boostTime <= 0 && boostammount != 1)
        {
            GameObject.Find("player").GetComponent<boatMovement>().TimedBonusSpeed = 1;
            GameObject.Find("player").GetComponent<boatMovement>().sailSpeed /= boostammount;
            boostammount = 1;
            boostTime = 0;

        }
    }

    public void setboost(float boostA)
    {
        boostTime = 5f;


        if (GameObject.Find("player").GetComponent<boatMovement>().TimedBonusSpeed == 1 || boostA > GameObject.Find("player").GetComponent<boatMovement>().TimedBonusSpeed)
        {
            GameObject.Find("player").GetComponent<boatMovement>().TimedBonusSpeed = boostA;
            GameObject.Find("player").GetComponent<boatMovement>().sailSpeed *= boostA;
            boostammount = boostA;
        }
    }
}
