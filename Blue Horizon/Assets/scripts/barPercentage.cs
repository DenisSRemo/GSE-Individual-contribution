using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barPercentage : MonoBehaviour
{
    public Transform bar;
    public float barPercent = 0;

    public void SetPercentage(float barP) {
        bar.localScale = new Vector2(barP, 1f);
    }
    // Should set the scale of the percentage bar depending on the value of barP, which should be barPercent when called.
    // 1 being full. 0 being empty.

    void Update()
    {
        SetPercentage(barPercent);
        if (barPercent > 1)
        {
            barPercent = 1;
        }
        else if (barPercent < 0) {
            barPercent = 0;
        }
        // Precautionary code to make sure there aren't any bad values.
    }
}