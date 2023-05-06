using UnityEngine;

public class dingSound : MonoBehaviour
{
    public static AudioClip dingy;
    static AudioSource audioSrc7;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc7 = GetComponent<AudioSource>();
        
        dingy = Resources.Load<AudioClip>("ding");
    }



    public static void playDing()
    {
        audioSrc7.PlayOneShot(dingy);
    }
}
