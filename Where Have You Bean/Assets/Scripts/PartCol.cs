using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartCol : MonoBehaviour
{
    public ParticleSystem BeenHit;
    public float damage = 1f;
    public HitHit idkman;
    // Start is called before the first frame update
    
    void OnParticleCollision (GameObject Sabean1)
    {
            Debug.Log("begin");

        BeenHit.Play();
        idkman.TakeDamage(damage);
        Gotem();

    }
    void Gotem()
    {
        dingSound.playDing();
    }

}
