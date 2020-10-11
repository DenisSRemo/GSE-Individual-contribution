using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPausedMenu;
    public GameObject Main_Menu;
    public GameObject Player_UI_Canvas;
    // Start is called before the first frame update
    void Start()
    {
        isPausedMenu = false;
        toggleMenu();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void toggleMenu()
    {
        isPausedMenu = !isPausedMenu;
        if (isPausedMenu)
        {
            Main_Menu.SetActive(true);
            Player_UI_Canvas.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            Main_Menu.SetActive(false);
            Time.timeScale = 1f;
            Invoke("enableUI", 1); //Loads in the UI after a 1 second delay.
            
        }
    }
    public void enableUI() {
        Player_UI_Canvas.SetActive(true);
    }
}