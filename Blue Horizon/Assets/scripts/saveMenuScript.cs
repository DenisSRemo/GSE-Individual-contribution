using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveMenuScript : MonoBehaviour
{

    public bool isSaveMenu;
    public GameObject Save_Menu;
    public GameObject Player_UI_Canvas;
    void Start()
    { 
        isSaveMenu = true;
        toggleSaveMenu();
    }

    public void toggleSaveMenu()
    {
        isSaveMenu = !isSaveMenu;
        if (isSaveMenu)
        {
            Save_Menu.SetActive(true);
            Player_UI_Canvas.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            Save_Menu.SetActive(false);
            Time.timeScale = 1f;
            Player_UI_Canvas.SetActive(true);
        }
    }
}

