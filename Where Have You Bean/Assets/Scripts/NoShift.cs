using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoShift : MonoBehaviour
{

    public static AudioClip noSh;
    static AudioSource audioSrc9;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc9 = GetComponent<AudioSource>();
        //
        noSh = Resources.Load<AudioClip>("alarm");
    }
    //make new particle system for no shift, then fix animations


    public static void playNoShi()
    {
        audioSrc9.PlayOneShot(noSh);
    }

    public static void stopNoShi()
    {

        audioSrc9.Stop();
    }




}
