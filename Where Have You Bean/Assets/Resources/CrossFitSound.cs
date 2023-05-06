using UnityEngine;

public class CrossFitSound : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip crossFitSound;
    static AudioSource audioSrc4;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc4 = GetComponent<AudioSource>();
        //
        crossFitSound = Resources.Load<AudioClip>("crossFitSound");
    }



    public static void playCrossfit()
    {
        audioSrc4.PlayOneShot(crossFitSound);
    }

}
