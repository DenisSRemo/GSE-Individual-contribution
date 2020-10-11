using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogColourChanger : MonoBehaviour
{
    private string currentBiome = PlayerStats.biome;
    private Color biomeColor;
    private int testIntVal = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q")) {
            testIntVal++;
            if (testIntVal >= 8) {
                testIntVal = 1;
            }
        }
        setFogColour();
    }

    public void setFogColour() {
        biomeColor = colorToBiome(currentBiome);
       // biomeColor = colorToBiomeTEST(testIntVal);
        RenderSettings.fogColor = biomeColor;
    }

    public Color colorToBiome(string currentBiome)
    {
        Color tempVal;
        switch (currentBiome)
        {
            case "Normal":
                tempVal = new Color(0.7f, 0.88f, 1f, 1f);
                break;
            case "Mountainous":
                tempVal = new Color(0.8f, 0.8f, 0.8f, 1f);
                break;
            case "Shallow":
                tempVal = new Color(0.6f, 1f, 1f, 1f);
                break;
            case "Sunrise":
                tempVal = new Color(1f, 0.85f, 0.45f, 1f);
                break;
            case "Swamp":
                tempVal = new Color(0.35f, 0.45f, 0.35f, 1f);
                break;
            case "Tundra":
                tempVal = new Color(0.87f, 0.99f, 1f, 1f);
                break;
            case "Twilight":
                tempVal = new Color(0.3f, 0.25f, 0.3f, 1f);
                break;
            default:
                tempVal = new Color(0.7f, 0.88f, 1f, 1f);
                break;
        }
        return tempVal;
    }

   /* public Color colorToBiomeTEST(int testValue)
    {
        Color tempVal;
        switch (testValue)
        {
            case 1:
                tempVal = new Color(0.7f, 0.88f, 1f, 1f);
                break;
            case 2:
                tempVal = new Color(0.8f, 0.8f, 0.8f, 1f);
                break;
            case 3:
                tempVal = new Color(0.6f, 1f, 1f, 1f);
                break;
            case 4:
                tempVal = new Color(1f, 0.85f, 0.45f, 1f);
                break;
            case 5:
                tempVal = new Color(0.35f, 0.45f, 0.35f, 1f);
                break;
            case 6:
                tempVal = new Color(0.87f, 0.99f, 1f, 1f);
                break;
            case 7:
                tempVal = new Color(0.3f, 0.25f, 0.3f, 1f);
                break;
            default:
                tempVal = new Color(1f, 0f, 0.9f, 1f);
                break;
        }
        return tempVal;
    }
    */
}
