using UnityEngine;


public class walkSound : MonoBehaviour
{
    //this is for shooting
    //this is for walking
    public static AudioClip walk;
    static AudioSource audioSrc1;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc1 = GetComponent<AudioSource>();
        //walk
        walk = Resources.Load<AudioClip>("walk");
    }



    public static void playwalk()
    {
        audioSrc1.PlayOneShot(walk);
    }
    public static void stopWalk()
    {
        audioSrc1.Stop();
    }


}