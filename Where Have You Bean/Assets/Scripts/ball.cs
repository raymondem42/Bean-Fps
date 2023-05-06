using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Animator anim;
    public Animator anim1;
    public Animator anim2;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim1 = gameObject.GetComponent<Animator>();
        anim2 = gameObject.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            anim.Play("balltime");
            anim1.Play("shrinko");
            anim2.Play("shinky");
   
        }

    }
}
