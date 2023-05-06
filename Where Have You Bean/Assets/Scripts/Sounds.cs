
using UnityEngine;

public class Sounds : MonoBehaviour
{
    //this is for shooting
    public static AudioClip bang;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        //shoot
        bang = Resources.Load<AudioClip>("bang");
        audioSrc = GetComponent<AudioSource>();

    }


    public static void playSound()
    {
        audioSrc.PlayOneShot(bang);
    }

}
