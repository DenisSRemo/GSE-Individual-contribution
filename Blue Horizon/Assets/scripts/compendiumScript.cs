using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class compendiumScript : MonoBehaviour
{

    public Text biomeText;
    public int currentPage;
    public GameObject biomeTextGO;
    void Start()
    {

        biomeText.text = "Normal";
        currentPage = 0;
        biomeTextGO.GetComponent<Text>().text = biomeText.text;
    }

    void Update()
    {

    }

    public void pageTurn(bool leftOrRight)
    {
        if (leftOrRight) //If going Left...
        {
            currentPage--; //Lower Value
            if (currentPage < 0) //If value is lower than 0
            {
                currentPage = 6; //Loop to 6
            }
        }
        else {
            currentPage++; // If going right, Raise Value
            if (currentPage > 6) { //If value is greater than 6
                currentPage = 0; //Loop to 0
            }
        }
        changeBiomeText(); //Changes text at the top to the new biome.
    }

    public void changeBiomeText() {
        switch (currentPage)
        {
            case 0:
                biomeText.text = "Normal";
                break;
            case 1:
                biomeText.text = "Tundra";
                break;
            case 2:
                biomeText.text = "Swamp";
                break;
            case 3:
                biomeText.text = "Mountain";
                break;
            case 4:
                biomeText.text = "Shallow";
                break;
            case 5:
                biomeText.text = "Twilight";
                break;
            case 6:
                biomeText.text = "Sunset";
                break;
            default:
                biomeText.text = "Normal";
                break;
        }
        biomeTextGO.GetComponent<Text>().text = biomeText.text;
    }
}
