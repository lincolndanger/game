using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float tlimer = .1f;
    public gun gvar;
    public float pierce;
    public float cpie;
    public int id;
    public static int globalID = 1;
    public float rotat = 0;
    public int cooler = 0;

    void Start()
    {
        id = globalID+1;
        globalID = globalID+2;
        //transform.LookAt(E1);
    }

    // Update is called once per frame
    void Update()
    {

        tlimer = tlimer + Time.deltaTime;
        transform.Translate(Time.deltaTime*gvar.sbeed,0,0);
        transform.Rotate(0f,0f,rotat);
        if(tlimer > gvar.lens)
            Destroy(gameObject);

    }
    void OnTriggerEnter2D(Collider2D collider)
    {   
        if(collider.tag == "WALL" && cooler == 0)
        {
            Destroy(gameObject);
        }

        if(collider.tag == "WALL" && cooler == 1)
        {
            transform.Rotate(0f,0f,135f);
        }
        switch (collider.tag)
        {
            case "E1" : 
            //    cpie = cpie + 2.5f;
            case "E2" :
            //    cpie = cpie + .5f;
            case "E3" :
                cpie = cpie + 1f;
                transform.Rotate(0f,0f,15f);
                if(cpie>=pierce)
                    Destroy(gameObject);
            break;
        }
    }
}
