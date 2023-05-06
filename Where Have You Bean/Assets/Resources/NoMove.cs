using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMove : MonoBehaviour
{
    public static AudioClip test;
    static AudioSource audioSrc6;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc6 = GetComponent<AudioSource>();
        //
        test = Resources.Load<AudioClip>("alarm");
    }



    public static void playTest()
    {
        audioSrc6.PlayOneShot(test);
    }

    public static void stopTest(){

        audioSrc6.Stop();
}


    }
