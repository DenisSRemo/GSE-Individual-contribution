using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openMap : MonoBehaviour
{
    public bool isPausedMap = false;
    public GameObject Map_Menu;
    public GameObject Player_UI_Canvas;
    public GameObject popUpMenu;
    public GameObject gameManager;
    private teleport teleportscript;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("game manager");
        Map_Menu.SetActive(false);
        teleportscript = gameManager.GetComponent<teleport>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void toggleMap()
    {       
        isPausedMap = !isPausedMap;
        if (isPausedMap)
        {
            Map_Menu.SetActive(true);
            Player_UI_Canvas.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            Map_Menu.SetActive(false);
            popUpMenu.SetActive(false);
            teleportscript.popUpActive = false;
            Player_UI_Canvas.SetActive(true);
            Time.timeScale = 1f;
        }
 
    }
}