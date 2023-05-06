using UnityEngine;

public class HitHit : MonoBehaviour
{
    // Update is called once per frame

    public float health = 3;

    public void TakeDamage (float amount)
    {
        health -= amount;

        if(health <= 0f)
        {
            die();
        }
    }
        void die()
    {
        Destroy(gameObject);
    }
}
