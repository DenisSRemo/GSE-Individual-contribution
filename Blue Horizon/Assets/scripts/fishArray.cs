using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

[System.Serializable]
public class fish
{
    public string fishName;
    public string fishRarity;
    public string fishBiome;
    public Sprite fishSprite;
    public string fishSpriteString;
    public bool FishIsOwned;
    public string FishIsOwnedString;
}

public class fishArray : MonoBehaviour
{
public Sprite spriteee;

public static fish[] NormalFish= new fish[21];
    public static fish[] TundraFish = new fish[21];
    public static fish[] MountainousFish = new fish[21];
    public static fish[] SwampFish = new fish[21];
    public static fish[] ShallowFish = new fish[21];
    public static fish[] TwilightFish = new fish[21];
    public static fish[] SunsetFish = new fish[21];

    public  List<string> name;
    public  List<string> biome;
    public  List<string> rarity;
    public  List<string> image;
    public  List<string> isCaught;


    private int rarityRange1;
    private int rarityRange2;
    private int rarityRange3;
    private int rarityRange4;
    // Start is called before the first frame update

    public fish RewardFish;
    public GameObject player;
    public GameObject gamemanager;
    void Start()
    {
        RewardFish = null;
       
      
        TextAsset fishfile = Resources.Load<TextAsset>("FishIndex");
        if (fishfile)
        {
            string[] data = fishfile.text.Split(new char[] { '\n' });
            //Debug.Log("data len"+data.Length);
            
            for (int i = 1; i < data.Length-1; i++)
            {
                string[] row=data[i].Split(new char[] { ',' });
                // Debug.Log(row[0]);
                //Debug.Log(i+" "+row[1]);
                name.Add(row[0]);
                biome.Add(row[1]);
                rarity.Add(row[2]);
                image.Add(row[3]);
                isCaught.Add(row[4]);
            }
           

        }
        else
        {
            Debug.Log("Can't read FishIndex file");
        } 

        
        for (int i = 0; i < 21; i++)
        {
            NormalFish[i] = new fish();
            NormalFish[i].fishName = name[i];
            NormalFish[i].fishBiome = biome[i];
            NormalFish[i].fishRarity = rarity[i];
            NormalFish[i].fishSpriteString = image[i];
            NormalFish[i].FishIsOwnedString = isCaught[i];
            NormalFish[i].fishSprite = Resources.Load<Sprite>("Fish_Images/Normal/" + NormalFish[i].fishSpriteString);
            NormalFish[i].FishIsOwned = false;

            TundraFish[i] = new fish();
            TundraFish[i].fishName = name[i + 21];
            TundraFish[i].fishBiome = biome[i + 21];
            TundraFish[i].fishRarity = rarity[i + 21];
            TundraFish[i].fishSpriteString = image[i + 21];
            TundraFish[i].FishIsOwnedString = isCaught[i + 21];
            TundraFish[i].fishSprite = Resources.Load<Sprite>("Fish_Images/Tundra/" + TundraFish[i].fishSpriteString);
            TundraFish[i].FishIsOwned = false;

            MountainousFish[i] = new fish();
            MountainousFish[i].fishName = name[i + 42];
            MountainousFish[i].fishBiome = biome[i + 42];
            MountainousFish[i].fishRarity = rarity[i + 42];
            MountainousFish[i].fishSpriteString = image[i + 42];
            MountainousFish[i].FishIsOwnedString = isCaught[i + 42];
            MountainousFish[i].fishSprite = Resources.Load<Sprite>("Fish_Images/Mountainous/" + MountainousFish[i].fishSpriteString);
            MountainousFish[i].FishIsOwned = false;

            SwampFish[i] = new fish();
            SwampFish[i].fishName = name[i + 63];
            SwampFish[i].fishBiome = biome[i + 63];
            SwampFish[i].fishRarity = rarity[i + 63];
            SwampFish[i].fishSpriteString = image[i + 63];
            SwampFish[i].FishIsOwnedString = isCaught[i + 63];
            SwampFish[i].fishSprite = Resources.Load<Sprite>("Fish_Images/Swamp/" + SwampFish[i].fishSpriteString);
            SwampFish[i].FishIsOwned = false;

            ShallowFish[i] = new fish();
            ShallowFish[i].fishName = name[i + 84];
            ShallowFish[i].fishBiome = biome[i + 84];
            ShallowFish[i].fishRarity = rarity[i + 84];
            ShallowFish[i].fishSpriteString = image[i + 84];
            ShallowFish[i].FishIsOwnedString = isCaught[i + 84];
            ShallowFish[i].fishSprite = Resources.Load<Sprite>("Fish_Images/Shallow/" + ShallowFish[i].fishSpriteString);
            ShallowFish[i].FishIsOwned = false;

            TwilightFish[i] = new fish();
            TwilightFish[i].fishName = name[i + 105];
            TwilightFish[i].fishBiome = biome[i + 105];
            TwilightFish[i].fishRarity = rarity[i + 105];
            TwilightFish[i].fishSpriteString = image[i + 105];
            TwilightFish[i].FishIsOwnedString = isCaught[i + 105];
            TwilightFish[i].fishSprite = Resources.Load<Sprite>("Fish_Images/Twilight/" + TwilightFish[i].fishSpriteString);
            TwilightFish[i].FishIsOwned = false;

            SunsetFish[i] = new fish();
            SunsetFish[i].fishName = name[i + 126];
            SunsetFish[i].fishBiome = biome[i + 126];
            SunsetFish[i].fishRarity = rarity[i + 126];
            SunsetFish[i].fishSpriteString = image[i + 126];
            SunsetFish[i].FishIsOwnedString = isCaught[i + 126];
            SunsetFish[i].fishSprite = Resources.Load<Sprite>("Fish_Images/Sunrise/" + SunsetFish[i].fishSpriteString);
            SunsetFish[i].FishIsOwned = false;
        }


    }
    public static bool[] SetAndGetFishBools()
    {
        bool[] fishBools =new bool[147];
        int j = 0;       
        for (int i = 0; i < NormalFish.Length; i++)
        {
            fishBools[j]=NormalFish[i].FishIsOwned;
            j++;
        }
        for (int i = 0; i < TundraFish.Length; i++)
        {
            fishBools[j] = TundraFish[i].FishIsOwned;
            j++;
        }
        for (int i = 0; i < MountainousFish.Length; i++)
        {
            fishBools[j] = MountainousFish[i].FishIsOwned;
            j++;
        }
        for (int i = 0; i < SwampFish.Length; i++)
        {
            fishBools[j] = SwampFish[i].FishIsOwned;
            j++;
        }
        for (int i = 0; i < ShallowFish.Length; i++)
        {
            fishBools[j] = ShallowFish[i].FishIsOwned;
            j++;
        }
        for (int i = 0; i < TwilightFish.Length; i++)
        {
            fishBools[j] = TwilightFish[i].FishIsOwned;
            j++;
        }
        for (int i = 0; i < SunsetFish.Length; i++)
        {
            fishBools[j] = SunsetFish[i].FishIsOwned;
            j++;
        }
        return fishBools;
}

    public static void LoadFishBool(bool[] list)
    {
        int j = 0;
        for (int i = 0; i < NormalFish.Length; i++)
        {
            NormalFish[i].FishIsOwned = list[j];
            TundraFish[i].FishIsOwned = list[j+20];
            MountainousFish[i].FishIsOwned = list[j+41];
            SwampFish[i].FishIsOwned = list[j+62];
            ShallowFish[i].FishIsOwned = list[j+83];
            TwilightFish[i].FishIsOwned = list[j+104];
            SunsetFish[i].FishIsOwned = list[j+125];
            j++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            gamemanager.GetComponent<wallRemover>().UnlockBiome();
        }
    }

    public void GetFish(string biome) { 
        //if (biome == null) {
        //    biome = "Normal"; // Error stopper.
        //}
        rarityOfFishRanges(biome); //Gets the percentage values for the rarity chance of each fish rarity for each biome.
        RewardFish= pickFish(pickBiome(biome));
        Debug.Log("you got the fish "+RewardFish.fishName+" from biome "+RewardFish.fishBiome);// First, it gets the array that matches the inputted biome, then uses that array to select a fish based on the percentage values from rarityOfFishRanges.
        StartCoroutine(GameObject.Find("Fish_Display").GetComponent<fishDisplay>().FishDisplayEnumerator(RewardFish));
    }


    public fish[] pickBiome(string biome) {
            
            fish[] returnbiome= null;
            switch (biome)
             {
            case "Normal":
                returnbiome = NormalFish;
                break;
            case "Tundra":
                returnbiome = TundraFish;
                break;
               
            case "Mountainous":
                returnbiome = MountainousFish;
                break;
                
            case "Swamp":
                returnbiome = SwampFish;
                break;
             
            case "Shallow":
                returnbiome = ShallowFish;
                break;
               
            case "Twilight":
                returnbiome = TwilightFish;
                break;
                
            case "Sunset":
                returnbiome = SunsetFish; 
                break;

             }

            if (returnbiome != null)
            {
              
                return returnbiome;

            }
            else
            {
               
                return null;
            }
    }


    public void rarityOfFishRanges(string biome) {
        switch (biome) {
            case "Normal":
                rarityRange1 = 30;
                rarityRange2 = 55;
                rarityRange3 = 75;
                rarityRange4 = 90;
                break;
            case "Tundra":
                rarityRange1 = 46;
                rarityRange2 = 67;
                rarityRange3 = 83;
                rarityRange4 = 94;
                break;
            case "Mountainous":
                rarityRange1 = 67;
                rarityRange2 = 82;
                rarityRange3 = 92;
                rarityRange4 = 97;
                break;
            case "Swamp":
                rarityRange1 = 60;
                rarityRange2 = 77;
                rarityRange3 = 89;
                rarityRange4 = 96;
                break;
            case "Shallow":
                rarityRange1 = 53;
                rarityRange2 = 72;
                rarityRange3 = 86;
                rarityRange4 = 95;
                break;
            case "Twilight":
                rarityRange1 = 70;
                rarityRange2 = 85;
                rarityRange3 = 95;
                rarityRange4 = 98;
                break;
            case "Sunset":
                rarityRange1 = 73;
                rarityRange2 = 88;
                rarityRange3 = 98;
                rarityRange4 = 99;
                break;
            default:
                rarityRange1 = 30;
                rarityRange2 = 55;
                rarityRange3 = 75;
                rarityRange4 = 90;
                break; // Error Stopper.
        }

    }


    public IEnumerator getFishEnumerator(float value)
    {
        yield return new WaitForSeconds(1f);
        float temp = Random.Range(0.0f, 1.0f);
      
        if (value > temp)
        {
         
            GetFish(PlayerStats.biome);
            Debug.Log(RewardFish.fishName);
            RewardFish.FishIsOwned = true;

            int totalFishOwned = 0;
            for (int i = 0; i < NormalFish.Length; i++)
            {
                if (NormalFish[i].FishIsOwned == true)
                    totalFishOwned++;
                if (TundraFish[i].FishIsOwned == true)
                    totalFishOwned++;
                if (MountainousFish[i].FishIsOwned == true)
                    totalFishOwned++;
                if (SwampFish[i].FishIsOwned == true)
                    totalFishOwned++;
                if (ShallowFish[i].FishIsOwned == true)
                    totalFishOwned++;
                if (TwilightFish[i].FishIsOwned == true)
                    totalFishOwned++;
                if (SunsetFish[i].FishIsOwned == true)
                    totalFishOwned++;
            
            }

            if (totalFishOwned % 10 == 0)
            {
                gamemanager.GetComponent<wallRemover>().UnlockBiome();
            }
            Debug.Log("total fish owned: "+totalFishOwned);




            Debug.Log("Back to fishing");

        }
        else
        {

            Debug.Log("no fish this time");
            player.GetComponent<boatMovement>().enabled = true;
            



        }
    }


    public fish pickFish(fish[] biomearray) {
        int range1 = 0;
        int range2 = 0;
      
        int rarityOfFish = Random.Range(0, 100); //0 to 100, 100 Exc.
        if (rarityOfFish >= 0 && rarityOfFish <= rarityRange1 - 1)
        {
            // Common.
            range1 = 0;
            range2 = 10;
        }
        else if (rarityOfFish >= rarityRange1 && rarityOfFish <= rarityRange2 - 1)
        {
            // Uncommon.
            range1 = 10;
            range2 = 15;
        }
        else if (rarityOfFish >= rarityRange2 && rarityOfFish <= rarityRange3 - 1)
        {
            // Rare.
            range1 = 15;
            range2 = 18;
        }
        else if (rarityOfFish >= rarityRange3 && rarityOfFish <= rarityRange4 - 1)
        {
            // Endangered.
            range1 = 18;
            range2 = 20;
        }
        else if (rarityOfFish >= rarityRange4 && rarityOfFish <= 99) {
            // Undiscovered.
            range1 = 20;
            range2 = 21;
        } else
        {
            range1 = 20;
            range2 = 21;
            // Error Stopper.
        }
        int specificFish = Random.Range(range1, range2);
        if (specificFish < 0) {
            specificFish = 0;
        } else if (specificFish > 100) { // Error Stopper.
            specificFish = 100;
        }
       
        return biomearray[specificFish];
    }



}
