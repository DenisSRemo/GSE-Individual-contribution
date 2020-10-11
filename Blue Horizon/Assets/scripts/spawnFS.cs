using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class spawnFS : MonoBehaviour
{
    public GameObject fishingspot;
    public GameObject fishingui;
    public GameObject player;

    public GameObject center1;
    public GameObject center2;
    public GameObject center3;
    public GameObject center4;
    public GameObject center5;
    public GameObject center6;
    public GameObject center7;
    public GameObject fishingspots;
    private List<GameObject> centers=new List<GameObject>();
   


    public int numberofFS;

    private float timeBetweenFishing = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        centers.Add(center1);
        centers.Add(center2);
        centers.Add(center3);
        centers.Add(center4);
        centers.Add(center5);
        centers.Add(center6);
        centers.Add(center7);
        numberofFS = 10;
        List<Vector3> RandVect = new List<Vector3>();//this will keep the positions of the fishing spots instantiated at the beggining of gameplay
        RandVect = GenerateRandVect(numberofFS);
        fishingui = GameObject.Find("fishingUI");
        
        for (int i = 0; i < RandVect.Count; i++)
        {
            GameObject newfishingspot = Instantiate(fishingspot, RandVect[i], Quaternion.identity);
            newfishingspot.transform.SetParent(fishingspots.transform);
        }
        fishingui.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        timeBetweenFishing += Time.deltaTime;
    }
    public void EnableFishingUI()
    {

        fishingui.SetActive(true);
        fishingui.GetComponent<spawndots>().numberOfbeats = 10;
        fishingui.GetComponent<spawndots>().numberOfbeatscopy = 10;

        string exportString = "";
        exportString += "Time between fishing spot: " + timeBetweenFishing.ToString();
        exportString += " Biome: " + player.GetComponent<PlayerStats>().getBiome();
        
        Debug.Log(exportString);
        
        AnalyticsExport.SendToExport(exportString);
    }
    public void DisableFishingUI()
    {
        fishingui.SetActive(false);
    }

    public void EndFishing()
    {
        timeBetweenFishing = 0.0f;
    }

    private List<Vector3> GenerateRandVect(int number)
    {
        List<Vector3> RandVec = new List<Vector3>();
        for (int j = 0; j < centers.Count; j++)
        {
            for (int i = 0; i < number; i++)
            {
                while (true)
                {
                    Vector3 newvex = new Vector3(Random.Range(centers[j].transform.position.x-500, centers[j].transform.position.x+500), 1f, Random.Range(centers[j].transform.position.z-500, centers[j].transform.position.z+500));
                    if (!RandVec.Contains(newvex))
                    {
                        RandVec.Add(newvex);
                        break;
                    }
                }
           
            }
        }
      

        return RandVec;
    }
}
