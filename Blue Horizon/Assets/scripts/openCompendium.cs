using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openCompendium : MonoBehaviour
{
    public bool isPausedCompendium = false;
    public GameObject Compendium_Menu;
    public GameObject Player_UI_Canvas;
    // Start is called before the first frame update
    void Start()
    {
        Compendium_Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void toggleCompendium() { 
        isPausedCompendium = !isPausedCompendium;
        if (isPausedCompendium)
        {
            Compendium_Menu.SetActive(true);
            Player_UI_Canvas.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            Compendium_Menu.SetActive(false);
            Player_UI_Canvas.SetActive(true);
            Time.timeScale = 1f;
        }
       
    }
}
