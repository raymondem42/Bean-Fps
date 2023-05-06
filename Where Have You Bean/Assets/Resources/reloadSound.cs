using UnityEngine;

public class reloadSound : MonoBehaviour
{ 

public static AudioClip reload;
static AudioSource audioSrc3;

// Start is called before the first frame update
void Start()
{
    audioSrc3 = GetComponent<AudioSource>();
    //
    reload = Resources.Load<AudioClip>("reload");
}



public static void playreload()
{
    audioSrc3.PlayOneShot(reload);
}

}
