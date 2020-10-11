using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Load_Buttons : MonoBehaviour
{
   
    public void SavePlayer()
    {
        SaveSystem.SavePlayer();
        Debug.Log("save");
        Debug.Log(PlayerStats.position);
    }
   
    public void LoadPlayer()
    {
        
        PlayerData data = SaveSystem.LoadPlayer();

        PlayerStats.position.x = data.playerlocation[0];
        PlayerStats.position.y = data.playerlocation[1];
        PlayerStats.position.z = data.playerlocation[2];

        PlayerStats.rotation.x = data.playerrotation[0];
        PlayerStats.rotation.y = data.playerrotation[1];
        PlayerStats.rotation.z = data.playerrotation[2];

        GameObject.Find("player").GetComponent<PlayerStats>().setPositionandRotation();
        fishArray.LoadFishBool(data.fishBools);
        Debug.Log("load");

        wallRemover.unlockedBiomes.Clear();
        for (int i = 0; i < data.unlockedBiomes.Length; i++)
        {
            if(data.unlockedBiomes[i]==0)
                break;
            wallRemover.unlockedBiomes.Add(data.unlockedBiomes[i]);
           
        }

        PermanentUpgrades.permanentCatchBoost = data.permanentUpgradeCatchRate;
        PermanentUpgrades.permanentSpeedBoost = data.permanentUpgradeSpeed;
        
        PlayerStats.TimeSpentInNormal = data.TimeSpentInNormal;
        PlayerStats.TimeSpentInSunrise = data.TimeSpentInSunrise;
        PlayerStats.TimeSpentInMountain = data.TimeSpentInMountain;
        PlayerStats.TimeSpentInShallow = data.TimeSpentInShallow;
        PlayerStats.TimeSpentInSwamp = data.TimeSpentInSwamp;
        PlayerStats.TimeSpentInTundra = data.TimeSpentInTundra;
        PlayerStats.TimeSpentInTwilight = data.TimeSpentInTwilight;



    }
  
}
