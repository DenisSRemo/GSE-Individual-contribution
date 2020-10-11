using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawndots : MonoBehaviour
{
    public GameObject beatPrefab;
    public GameObject checkPrefab;
    public Slider sliderprefab;

    GameObject check;
    Slider slider;
    public int numberOfbeats;
    public int numberOfbeatscopy;
    public float result;

    Vector3 whereToSpawn; //position of the beat
    Vector3 whereToSpawnCheck; //position of the check
    Vector3 whereToSpawnSlider;
    private float time;


    private float x; //x pos of beat
    private float checkx; //x pos of check
    private float y; //y pos of beat
    private float checky; //y pos of check
    private float sliderX;
    private float sliderY;


    public float spawnSpeed; //time between beats spawn;
    public float beatSpeed; //speed at which the beat is traveling
    public float beatScale; //scale of the beat
    public float checkScale; //scale of check
    public Vector3 sliderscale;

    public GameObject Player_UI;
    public GameObject player;
    

    void Start()
    {
        spawnSpeed = 1;
        beatSpeed = 300;
        beatScale = 2;
        checkScale = 2;


        time = Time.time;
        x = Screen.width * 0.85f;
        checkx = Screen.width * 0.15f;
        y = Screen.height * 0.9f;
        checky = Screen.height * 0.9f;

        sliderX = Screen.width * 0.9f;
        sliderY = Screen.height * 0.9f;

        whereToSpawn.x = x;
        whereToSpawn.y = y;
        whereToSpawnCheck.x = checkx;
        whereToSpawnCheck.y = checky;
        whereToSpawnSlider.x = sliderX;
        whereToSpawnSlider.y = sliderY;


        //check = Instantiate(checkPrefab, whereToSpawnCheck, Quaternion.identity, transform);
        //check.name = "Check";
    }

    private void OnEnable()
    {
    

        Player_UI.SetActive(false);
        numberOfbeatscopy = numberOfbeats;
        time = Time.time;
        x = Screen.width * 0.85f;
        checkx = Screen.width * 0.15f;
        y = Screen.height * 0.9f;
        checky = Screen.height * 0.9f;
        sliderX = Screen.width * 0.5f;
        sliderY = Screen.height * 0.9f;

        whereToSpawn.x = x;
        whereToSpawn.y = y;
        whereToSpawnCheck.x = checkx;
        whereToSpawnCheck.y = checky;
        whereToSpawnSlider.x = sliderX;
        whereToSpawnSlider.y = sliderY - 76;


        if (!GameObject.Find("Slider")) //if there is no check we create one
        {
            slider = Instantiate(sliderprefab, whereToSpawnSlider, Quaternion.identity, transform);
            slider.name = "Slider";
            slider.GetComponent<RectTransform>().localScale = new Vector3(18, 13, 0);
            // slider.GetComponent<RectTransform>().position.= new Vector3(0, 500, 0);
            slider.value = 0;
        }

        if (!GameObject.Find("Check")) //if there is no check we create one
        {
            check = Instantiate(checkPrefab, whereToSpawnCheck, Quaternion.identity, transform);
            check.name = "Check";
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= time && numberOfbeats > 0)
        {
            spawnSpeed = Random.Range(0.3f, 1f);
            time += spawnSpeed;
            GameObject bt = Instantiate(beatPrefab, whereToSpawn, Quaternion.identity, transform);
            bt.GetComponent<moveBeats>().speed = beatSpeed;
            bt.transform.localScale = new Vector3(beatScale, beatScale, beatScale);
            bt.name = "beat";
            numberOfbeats--; //each time when a beat is spawned this will be decreased by 1, when it reaches 0 the rythm game ends
        }

        slider.value = (float) GameObject.Find("Check").GetComponent<checkTouch>().score / (float) numberOfbeatscopy;

        if (numberOfbeats == 0 && GameObject.Find("beat") == null)
        {
            result = (float) GameObject.Find("Check").GetComponent<checkTouch>().score / (float) numberOfbeatscopy;
            float finalres = GameObject.Find("player").GetComponent<PermanentUpgrades>().ReturnPercentage(result);
            StartCoroutine(GameObject.Find("Fish Objects").GetComponent<fishArray>().getFishEnumerator(finalres));
            StartCoroutine(SimnpleDelay()); // wait a bit more after the last beat is gone 
        }
        check.transform.localScale = new Vector3(checkScale, checkScale, checkScale);
    }

    IEnumerator SimnpleDelay()
    {
        yield return new WaitForSeconds(1f);
        slider.value = 0;
        gameObject.SetActive(false);
        Player_UI.SetActive(true);
        //gameObject.GetComponent<spawndots>().enabled = false;
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}