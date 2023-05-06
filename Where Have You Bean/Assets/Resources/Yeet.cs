using UnityEngine;

public class Yeet : MonoBehaviour
{
    // Start is called before the first frame update

    public static AudioClip yeet;
    static AudioSource audioSrc5;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc5 = GetComponent<AudioSource>();
        //
        yeet = Resources.Load<AudioClip>("Yeet");
    }



    public static void playYeet()
    {
        audioSrc5.PlayOneShot(yeet);
    }
    }
