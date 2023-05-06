using UnityEngine;

public class ShapeShift : MonoBehaviour
{
    // Start is called before the first frame update
    public float startTime = 0;
    public float holdTime = 3;
    public float holdTimeCow = 3;
    public float holdTimeTomato = 3;
    public float holdTimeTree = 3;
    public float holdTimeBroc = 3;
    public float holdTimeChicken = 3;
    public float holdTimeTractor = 3;
    public float holdTimeWheelBarrel = 3;
    public float holdTimeScarecrow = 3;
    public float holdTimeWindmill = 3;

    public float shiftChange = 25;
    public float B = 0;
    public Camera cam;

    public int cass = 0;
    public int cassTomato = 0;
    public int cassTree = 0;
    public int cassBroc = 0;
    public int cassChicken = 0;
    public int cassTractor = 0;
    public int cassWheelBarrel = 0;
    public int cassScarecrow = 0;
    public int cassWindmill = 0;
   

    public float ay = 0;
    public Animator anim;
    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator cow;
    public Animator Tomato;
    public Animator Tree;
    public Animator Broc;
    public Animator Chicken;
    public Animator Tractor;
    public Animator WheelBarrel;
    public Animator Scarecrow;
    public Animator Windmill;
    public ParticleSystem noShiftin;


    void start()
    {

        anim = gameObject.GetComponent<Animator>();
        anim1 = gameObject.GetComponent<Animator>();
        anim2 = gameObject.GetComponent<Animator>();
        anim3 = gameObject.GetComponent<Animator>();
        cow = gameObject.GetComponent<Animator>();
        Tomato = gameObject.GetComponent<Animator>();
        Tree = gameObject.GetComponent<Animator>();
        Broc = gameObject.GetComponent<Animator>();
        Chicken = gameObject.GetComponent<Animator>();
        Tractor = gameObject.GetComponent<Animator>();
        WheelBarrel = gameObject.GetComponent<Animator>();
        Scarecrow = gameObject.GetComponent<Animator>();
        Windmill = gameObject.GetComponent<Animator>();
        noShiftin = gameObject.GetComponent<ParticleSystem>();
    }

    private void Update()
    {

        shiftChange -= Time.deltaTime;

        if (shiftChange <= 0)
        {
            shiftChange = 0;
        }
        if (shiftChange == 0)
        {
            shiftcheck();
        }

        if (B > 1)
        {
            noShiftin.Play();
        }

        if (ay == 0)
        {
            shiftconfirm();
        }

        if (ay ==1 )
        {
            NoCamp();
        }


        //after a timer, a number will go up and if it is equal to 1 then it make noise
        if (Input.GetKey(KeyCode.E))
        {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


                if (Physics.Raycast(ray, out hit, 100f))
            {

                if (hit.transform.tag == "sphere" && Input.GetKey(KeyCode.E)) {
                    holdTime -= Time.deltaTime;
                }

                if (hit.transform.tag == "Cow" && Input.GetKey(KeyCode.E))
                {
                    holdTimeCow -= Time.deltaTime;
                }

                if (hit.transform.tag == "Tomato" && Input.GetKey(KeyCode.E))
                {
                    holdTimeTomato -= Time.deltaTime;
                }

                if (hit.transform.tag == "Tree" && Input.GetKey(KeyCode.E))
                {
                    holdTimeTree -= Time.deltaTime;
                }

                if (hit.transform.tag == "Broc" && Input.GetKey(KeyCode.E))
                {
                    holdTimeBroc -= Time.deltaTime;
                }

                if (hit.transform.tag == "Chicken" && Input.GetKey(KeyCode.E))
                {
                    holdTimeChicken -= Time.deltaTime;
                }

                if (hit.transform.tag == "Tractor" && Input.GetKey(KeyCode.E))
                {
                    holdTimeTractor -= Time.deltaTime;
                }

                if (hit.transform.tag == "WheelBarrel" && Input.GetKey(KeyCode.E))
                {
                    holdTimeWheelBarrel -= Time.deltaTime;
                }

                if (hit.transform.tag == "Scarecrow" && Input.GetKey(KeyCode.E))
                {
                    holdTimeScarecrow -= Time.deltaTime;
                }

                if (hit.transform.tag == "Windmill" && Input.GetKey(KeyCode.E))
                {
                    holdTimeWindmill -= Time.deltaTime;
                }
                if (holdTime < 0)
                {
                    holdTime = 0;
                }

           
                if (holdTime == 0)
                {
                        switchChar();
                }

                if (holdTimeCow < 0)
                {
                    holdTimeCow = 0;
                }
                if(holdTimeCow == 0)
                {
                    switchCow();
                }

                if(holdTimeTomato < 0)
                {
                    holdTimeTomato = 0;
                }
                if(holdTimeTomato == 0)
                {
                    switchTomato();
                }
                
                if(holdTimeTree < 0)
                {
                    holdTimeTree = 0;
                }

                if(holdTimeTree == 0)
                {
                    switchTree();
                }

                if (holdTimeBroc < 0)
                {
                    holdTimeBroc = 0;
                }

                if (holdTimeBroc == 0)
                {
                    switchBroc();
                }

                if (holdTimeChicken < 0)
                {
                    holdTimeChicken = 0;
                }

                if (holdTimeChicken == 0)
                {
                    switchChicken();
                }

                if (holdTimeTractor < 0)
                {
                    holdTimeTractor = 0;
                }

                if (holdTimeTractor == 0)
                {
                    switchTractor();
                }

                if (holdTimeWheelBarrel < 0)
                {
                    holdTimeWheelBarrel = 0;
                }

                if (holdTimeWheelBarrel == 0)
                {
                    switchWheelBarrel();
                }

                if (holdTimeScarecrow < 0)
                {
                    holdTimeScarecrow = 0;
                }

                if (holdTimeScarecrow == 0)
                {
                    switchScarecrow();
                }

                if (holdTimeWindmill < 0)
                {
                    holdTimeWindmill = 0;
                }

                if (holdTimeWindmill == 0)
                {
                    switchWindmill();
                }
            }
           
        }
        if (!Input.GetKey(KeyCode.E))
        {
            holdTime = 3;
            holdTimeCow = 3;
            holdTimeTomato = 3;
            holdTimeTree = 3;
            holdTimeBroc = 3;
            holdTimeChicken = 3;
            holdTimeTractor = 3;
            holdTimeWheelBarrel = 3;
            holdTimeScarecrow = 3;
            holdTimeWindmill = 3;
        }
        }

    private void NoCamp()
    {
        NoShift.playNoShi();
    }

    private void shiftcheck()
    {
        ay++;
        B++;

    }
    private void switchChar()
    {
      
        anim1.Play("shrinko");
        anim2.Play("shinky");
        cow.Play("CowShrink");
        Tomato.Play("TomatoShrink");
        Tree.Play("TreeShrink");
        Broc.Play("BrocShrink");
        Chicken.Play("ChickenShrink");
        
            Scarecrow.Play("ScarecrowShrink");

            Windmill.Play("WindmillShrink");
        

        WheelBarrel.Play("WheelBarrelShrink");
       
        anim.Play("balltime");

        holdTime = 3;
        shiftChange = 25;
        noShiftin.Stop();
        ay = 0;
        B = 0;
        cam.nearClipPlane = 0.3f;

    }

    private void switchCow()
    {
        for (cass = 0; cass < 13; cass++){
            if (cass == 1)
            {
                Tomato.Play("TomatoShrink");
            }
            if (cass == 2)
            {
                anim1.Play("shrinko");
            }

            if (cass == 3)
            {
                anim2.Play("shinky");
            }
            if (cass == 4)
            {
                anim3.Play("BallShrink");
            }
            if (cass == 5)
            {
                Tree.Play("TreeShrink");
            }
            if (cass == 6)
            {
                Broc.Play("BrocShrink");
            }
            if (cass == 7)
            {
                   Chicken.Play("ChickenShrink");
            }

            if (cass == 8)
            {
                cow.Play("CowMode");
            }

            if (cass == 9)
            {
                Tractor.Play("TractorShrink");
            }
            if (cass == 10)
            {
                WheelBarrel.Play("WheelBarrelShrink");
            }
            if (cass == 11)
            {
                Scarecrow.Play("ScarecrowShrink");
            }

            if (cass == 12)
            {
                Windmill.Play("WindmillShrink");
            }
        }

        cass = 0;
        holdTimeCow = 3;
        shiftChange = 25;
        noShiftin.Stop();
        ay = 0;
        B = 0;
        cam.nearClipPlane = 0.3f;

    }

    private void switchTomato()
    {

        for (cassTomato = 0; cassTomato < 13; cassTomato++)
        {
            if (cassTomato == 1)
            {
                Tomato.Play("TomatoMode");
            }
            if (cassTomato == 2)
            {
                anim1.Play("shrinko");
            }

            if (cassTomato == 3)
            {
                anim2.Play("shinky");
            }
            if (cassTomato == 4)
            {
                anim3.Play("BallShrink");
            }
            if (cassTomato == 5)
            {
                Tree.Play("TreeShrink");
            }
            if (cassTomato == 6)
            {
                Broc.Play("BrocShrink");
            }
            if (cassTomato == 7)
            {
                Chicken.Play("ChickenShrink");
            }

            if (cassTomato == 8)
            {
                cow.Play("CowShrink");
            }

            if (cassTomato == 9)
            {
                Tractor.Play("TractorShrink");
            }
            if (cassTomato == 10)
            {
                WheelBarrel.Play("WheelBarrelShrink");
            }

            if (cassTomato == 11)
            {
                Scarecrow.Play("ScarecrowShrink");
            }

            if (cassTomato == 12)
            {
                Windmill.Play("WindmillShrink");
            }
        }

        cassTomato = 0;
        holdTimeTomato = 3;
        shiftChange = 25;
        noShiftin.Stop();
        ay = 0;
        B = 0;
        cam.nearClipPlane = 3.2f;
    }


    private void switchTree()
    {

        for (cassTree = 0; cassTree < 13; cassTree++)
        {
            if (cassTree == 1)
            {
                Tomato.Play("TomatoShrink");
            }
            if (cassTree == 2)
            {
                anim1.Play("shrinko");
            }

            if (cassTree == 3)
            {
                anim2.Play("shinky");
            }
            if (cassTree == 4)
            {
                anim3.Play("BallShrink");
            }
            if (cassTree == 5)
            {
                Tree.Play("TreeMode");
            }
            if (cassTree == 6)
            {
                Broc.Play("BrocShrink");
            }
            if (cassTree == 7)
            {
                Chicken.Play("ChickenShrink");
            }

            if (cassTree == 8)
            {
                cow.Play("CowShrink");
            }

            if (cassTree == 9)
            {
                Tractor.Play("TractorShrink");
            }
            if (cassTree == 10)
            {
                WheelBarrel.Play("WheelBarrelShrink");
            }

            if (cassTree == 11)
            {
                Scarecrow.Play("ScarecrowShrink");
            }

            if (cassTree == 12)
            {
                Windmill.Play("WindmillShrink");
            }
        }

        cassTree = 0;
        holdTimeTree = 3;
        shiftChange = 25;
        noShiftin.Stop();
        ay = 0;
        B = 0;
        cam.nearClipPlane = 2.8f;
    }

    private void switchBroc()
    {

        for (cassBroc = 0; cassBroc < 13; cassBroc++)
        {
            if (cassBroc == 1)
            {
                Tomato.Play("TomatoShrink");
            }
            if (cassBroc == 2)
            {
                anim1.Play("shrinko");
            }

            if (cassBroc == 3)
            {
                anim2.Play("shinky");
            }
            if (cassBroc == 4)
            {
                anim3.Play("BallShrink");
            }
            if (cassBroc == 5)
            {
                Tree.Play("TreeShrink");
            }
            if (cassBroc == 6)
            {
                Broc.Play("BrocMode");
            }
            if (cassBroc == 7)
            {
                Chicken.Play("ChickenShrink");
            }

            if (cassBroc == 8)
            {
                cow.Play("CowShrink");
            }

            if (cassBroc == 9)
            {
                Tractor.Play("TractorShrink");
            }
            if (cassBroc == 10)
            {
                WheelBarrel.Play("WheelBarrelShrink");
            }

            if (cassBroc == 11)
            {
                Scarecrow.Play("ScarecrowShrink");
            }

            if (cassBroc == 12)
            {
                Windmill.Play("WindmillShrink");
            }
        }

        cassBroc = 0;
        holdTimeBroc = 3;
        shiftChange = 25;
        noShiftin.Stop();
        ay = 0;
        B = 0;
        cam.nearClipPlane = 3.27f;

    }

    private void switchChicken()
    {

        for (cassChicken = 0; cassChicken < 13; cassChicken++)
        {
            if (cassChicken == 1)
            {
                Tomato.Play("TomatoShrink");
            }
            if (cassChicken == 2)
            {
                anim1.Play("shrinko");
            }

            if (cassChicken == 3)
            {
                anim2.Play("shinky");
            }
            if (cassChicken == 4)
            {
                anim3.Play("BallShrink");
            }
            if (cassChicken == 5)
            {
                Tree.Play("TreeShrink");
            }
            if (cassChicken == 6)
            {
                Broc.Play("BrocShrink");
            }
            if (cassChicken == 7)
            {
                Chicken.Play("ChickenMode");
            }

            if (cassChicken == 8)
            {
                cow.Play("CowShrink");
            }

            if (cassChicken == 9)
            {
                Tractor.Play("TractorShrink");
            }
            if (cassChicken == 10)
            {
                WheelBarrel.Play("WheelBarrelShrink");
            }

            if (cassChicken == 11)
            {
                Scarecrow.Play("ScarecrowShrink");
            }

            if (cassChicken == 12)
            {
                Windmill.Play("WindmillShrink");
            }
        }



        cassChicken = 0;
        holdTimeChicken = 3;
        shiftChange = 25;
        noShiftin.Stop();
        ay = 0;
        B = 0;
        cam.nearClipPlane = 2f;
    }

    private void switchTractor()
    {
        for (cassTractor = 0; cassTractor < 13; cassTractor++)
        {
            if (cassTractor == 1)
            {
                Tomato.Play("TomatoShrink");
            }
            if (cassTractor == 2)
            {
                anim1.Play("shrinko");
            }

            if (cassTractor == 3)
            {
                anim2.Play("shinky");
            }
            if (cassTractor == 4)
            {
                anim3.Play("BallShrink");
            }
            if (cassTractor== 5)
            {
                Tree.Play("TreeShrink");
            }
            if (cassTractor == 6)
            {
                Broc.Play("BrocShrink");
            }
            if (cassTractor == 7)
            {
                Chicken.Play("ChickenShrink");
            }

            if (cassTractor == 8)
            {
                cow.Play("CowShrink");
            }

            if(cassTractor == 9)
            {
                Tractor.Play("TractorMode");
            }

            if (cassTractor == 10)
            {
                WheelBarrel.Play("WheelBarrelShrink");
            }

            if (cassTractor == 11)
            {
                Scarecrow.Play("ScarecrowShrink");
            }

            if (cassTractor == 12)
            {
                Windmill.Play("WindmillShrink");
            }
        }

        cassTractor = 0;
        holdTimeTractor = 3;
        shiftChange = 25;
        noShiftin.Stop();
        ay = 0;
        B = 0;
        cam.nearClipPlane = 3.8f;
    }



    private void switchWheelBarrel()
    {
        for (cassWheelBarrel = 0; cassWheelBarrel < 13; cassWheelBarrel++)
        {
            if (cassWheelBarrel == 1)
            {
                Tomato.Play("TomatoShrink");
            }
            if (cassWheelBarrel == 2)
            {
                anim1.Play("shrinko");
            }

            if (cassWheelBarrel == 3)
            {
                anim2.Play("shinky");
            }
            if (cassWheelBarrel == 4)
            {
                anim3.Play("BallShrink");
            }
            if (cassWheelBarrel == 5)
            {
                Tree.Play("TreeShrink");
            }
            if (cassWheelBarrel == 6)
            {
                Broc.Play("BrocShrink");
            }
            if (cassWheelBarrel == 7)
            {
                Chicken.Play("ChickenShrink");
            }

            if (cassWheelBarrel == 8)
            {
                cow.Play("CowShrink");
            }
            
            if (cassWheelBarrel == 9)
            {
                Tractor.Play("TractorShrink");
            }
            if (cassWheelBarrel == 10)
            {
                WheelBarrel.Play("WheelBarrelMode");
            }

            if (cassWheelBarrel == 11)
            {
                Scarecrow.Play("ScarecrowShrink");
            }

            if (cassWheelBarrel == 12)
            {
                Windmill.Play("WindmillShrink");
            }
        }

        cassWheelBarrel = 0;
        holdTimeWheelBarrel = 3;
        shiftChange = 25;
        noShiftin.Stop();
        ay = 0;
        B = 0;
        cam.nearClipPlane = 2.5f;
    }


    private void switchScarecrow()
    {
        for (cassScarecrow = 0; cassScarecrow < 13; cassScarecrow++)
        {
            if (cassScarecrow == 1)
            {
                Tomato.Play("TomatoShrink");
            }
            if (cassScarecrow == 2)
            {
                anim1.Play("shrinko");
            }

            if (cassScarecrow == 3)
            {
                anim2.Play("shinky");
            }
            if (cassScarecrow == 4)
            {
                anim3.Play("BallShrink");
            }
            if (cassScarecrow == 5)
            {
                Tree.Play("TreeShrink");
            }
            if (cassScarecrow == 6)
            {
                Broc.Play("BrocShrink");
            }
            if (cassScarecrow == 7)
            {
                Chicken.Play("ChickenShrink");
            }

            if (cassScarecrow == 8)
            {
                cow.Play("CowShrink");
            }

            if (cassScarecrow == 9)
            {
                Tractor.Play("TractorShrink");
            }
            if (cassScarecrow == 10)
            {
                WheelBarrel.Play("WheelBarrelShrink");
            }
            
            if(cassScarecrow == 11)
            {
                Scarecrow.Play("ScarecrowMode");
            }

            if (cassScarecrow == 12)
            {
                Windmill.Play("WindmillShrink");
            }
        }

        cassScarecrow = 0;
        holdTimeScarecrow = 3;
        shiftChange = 25;
        noShiftin.Stop();
        ay = 0;
        B = 0;
        cam.nearClipPlane = 1.2f;
    }

    private void switchWindmill()
    {
        for (cassWindmill = 0; cassWindmill < 13; cassWindmill++)
        {
            if (cassWindmill == 1)
            {
                Tomato.Play("TomatoShrink");
            }
            if (cassWindmill == 2)
            {
                anim1.Play("shrinko");
            }

            if (cassWindmill == 3)
            {
                anim2.Play("shinky");
            }
            if (cassWindmill == 4)
            {
                anim3.Play("BallShrink");
            }
            if (cassWindmill == 5)
            {
                Tree.Play("TreeShrink");
            }
            if (cassWindmill == 6)
            {
                Broc.Play("BrocShrink");
            }
            if (cassWindmill == 7)
            {
                Chicken.Play("ChickenShrink");
            }

            if (cassWindmill == 8)
            {
                cow.Play("CowShrink");
            }

            if (cassWindmill == 9)
            {
                Tractor.Play("TractorShrink");
            }
            if (cassWindmill == 10)
            {
                WheelBarrel.Play("WheelBarrelShrink");
            }
            if (cassWindmill == 11)
            {
                Scarecrow.Play("ScarecrowShrink");
            }

            if (cassWindmill == 12)
            {
                Windmill.Play("WindmillMode");
            }
        }

        cassWindmill = 0;
        holdTimeWindmill = 3;
        shiftChange = 25;
        noShiftin.Stop();
        ay = 0;
        B = 0;
        cam.nearClipPlane = 1.3f;

    }

    //make new audiosource and script and work from there 
    private void shiftconfirm(){
        if (ay < 1)
        {
            noShiftin.Stop();
            NoShift.stopNoShi();
        }
    }

}


