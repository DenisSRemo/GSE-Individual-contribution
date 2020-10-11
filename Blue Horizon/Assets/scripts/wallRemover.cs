using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class wallRemover : MonoBehaviour
{
    public GameObject[] biomes;
    public static  List<int> unlockedBiomes;
    public List<int> lockedBiomes;
    public float current_time;


    
    // Start is called before the first frame update
    void Start()
    {
        unlockedBiomes=new List<int>();
       
        lockedBiomes.Add(1);
        lockedBiomes.Add(2);
        lockedBiomes.Add(3);
        lockedBiomes.Add(4);
        lockedBiomes.Add(5);
        lockedBiomes.Add(6);



        unlockedBiomes.Add(0);
        //unlockedBiomes.Add(1);
        //unlockedBiomes.Add(2);
        //unlockedBiomes.Add(3);
        //unlockedBiomes.Add(4);
        //unlockedBiomes.Add(5);
        //unlockedBiomes.Add(6);

        current_time = Time.time;
    }

    public void UnlockBiome()
    {
        string namebiom = lockedBiomes[0].ToString();
        unlockedBiomes.Add(lockedBiomes[0]);
        lockedBiomes.RemoveAt(0);
        
        StartCoroutine(DestroyWallsBetweenAll(unlockedBiomes));
        float time = Time.time - current_time;
        AnalyticsExport.SendToExport("Time to unlock "+namebiom+time.ToString());
        current_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
       // StartCoroutine(DestroyWallsBetweenAll(unlockedBiomes));
    }

    IEnumerator DestroyWallsBetween(int first, int second)
    {

        RaycastHit hit;
        if (Physics.Linecast(biomes[first].transform.position, biomes[second].transform.position,out hit))
        {
            if (hit.transform.tag=="wall")
            {
                Destroy(hit.transform.gameObject);
            }
          
        }
        yield return null;
    }

    IEnumerator DestroyWallsBetweenAll(List<int> unlocked)
    {
        for(int i=0;i<unlocked.Count;i++)
            for (int j = 0; j < unlocked.Count; j++)
            {
               
                StartCoroutine(DestroyWallsBetween(unlocked[i], unlocked[j]));
            }
        yield return null;
    }
    
}
