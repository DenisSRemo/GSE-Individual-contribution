using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class fishDisplay : MonoBehaviour
{
    public GameObject PlayerUI;
    public GameObject FishCanvas;
    public GameObject FishSprite;

    public GameObject ESystem;

    public TextMeshProUGUI FishText;
    
    public Color textColor;

    public string rarity;


    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        FishCanvas.SetActive(false);
        ESystem = GameObject.Find("EventSystem");
    }

    /*
    void Update()
    {
        if (Input.GetKey("up")) {
            testEnable("Tuna", rarity);
        }
    } */



    public void testEnable(fish m_fish) {

        ESystem.GetComponent<tutorialScript>().firstFish = true;
        
        FishCanvas.SetActive(true);
        PlayerUI.SetActive(false);

        FishText.text = m_fish.fishName;

        FishSprite.GetComponent<Image>().sprite = m_fish.fishSprite;

        //Time.timeScale = 0f;

        switch (m_fish.fishRarity) {
            case "Common":
                FishText.color = new Color(1f, 1f, 1f, 1f);
                break;
            case "Uncommon":
                FishText.color = new Color(0f, 0f, 1f, 1f);
                break;
            case "Rare":
                FishText.color = new Color(0f, 0.75f, 0f, 1f);
                break;
            case "Endangered":
                FishText.color = new Color(0.5f, 0f, 1f, 1f);
                break;
            case "Undiscovered":
                FishText.color = new Color(1f, 0.92f, 0.016f, 1f);
                break;
            default:
                FishText.color = new Color(0f, 0f, 0f, 1f);
                break;
        }



    }

    public void disableDisplay() {

        FishCanvas.SetActive(false);
        PlayerUI.SetActive(true);
        player.GetComponent<boatMovement>().enabled = true;
        GameObject.Find("game manager").GetComponent<spawnFS>().EndFishing();

        //   Time.timeScale = 1f;
    }

    public IEnumerator FishDisplayEnumerator(fish fish)
    {
        testEnable(fish);
        yield return new WaitForSeconds(3);
        disableDisplay();
    }
}
