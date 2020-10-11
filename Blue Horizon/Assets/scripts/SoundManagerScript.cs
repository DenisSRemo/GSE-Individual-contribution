using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip beatSuccess, beatFailure;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        beatSuccess = Resources.Load<AudioClip>("beatSuccess");
        beatFailure = Resources.Load<AudioClip>("beatFailure");


        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip) {
        switch (clip) {
            case "beatSuccess":
                audioSrc.PlayOneShot(beatSuccess);
                break;
            case "beatFailure":
                audioSrc.PlayOneShot(beatFailure);
                break;
        }
    }
}
