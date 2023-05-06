using UnityEngine;

public class PewPew : MonoBehaviour
{

    public float range = 100f;
    public Camera fpsCam;
    public ParticleSystem rooster;
    public PartCol boyo;
    public float ammo = 20;

    public static AudioClip bang;
    static AudioSource bng;

    public bool ammoFill;
    public LayerMask AmmoPacko;


    // Update is called once per frame



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shoot();
        }

        ammoFill = Physics.CheckSphere(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), 10f, AmmoPacko);


        if(ammoFill && ammo < 20)
        {
            reloadme();
        }

        if (ammoFill)
        {
            ammo = 20;
        }

    }

    void shoot()
    {
        ammo--;
        if (ammo >= 0)
        {
            rooster.Play();
            Sounds.playSound();
        }
    }

    void reloadme()
    {
        reloadSound.playreload();

    }

}
