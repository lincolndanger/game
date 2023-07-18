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
    public float range = 1000000;
    public int seek = 0;
    public int shra = 0;
    public int speedoff = 1;

    void Start()
    {
        id = globalID+1;
        globalID = globalID+2;
        //transform.LookAt(E1);
        if (speedoff == 1)
        {
            Time.timeScale = 1;
        }
        if (seek ==1)
        {   
            GameObject genemy;

            genemy = findenemy();
            
            // foreach (GameObject mean in spawn.allEnemies)
            // {
            //     cdist = Vector3.Distance(this.gameObject.transform.position, mean.transform.position);
            //     if (cdist<= odist)
            //     {
            //         odist = cdist;
            //         transform.LookAt(mean.transform);
            //         transform.eulerAngles = new Vector3(0,0, transform.eulerAngles.z);
            //     }
            // }
            
        }
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
                if(shra == 0)
                    transform.Rotate(0f,0f,15f);
                if(cpie>=pierce)
                    Destroy(gameObject);
                if (seek ==1)
                {   
                    GameObject genemy;

                    genemy = findenemy();
                }
                // if (seek ==1)
                // {
                //     // foreach (GameObject mean in spawn.allEnemies)
                //     // {
                //     // cdist = Vector3.Distance(this.gameObject.transform.position, mean.transform.position);
                //     // if (cdist<= odist)
                //     // {
                //     //     odist = cdist;
                //     //     transform.LookAt(mean.transform);
                //     //     transform.eulerAngles = new Vector3(0,0, transform.eulerAngles.z);
                //     // }
                //     // }
            
                // }
            break;
        }
    }

    GameObject findenemy()
    {
        GameObject closest = gameObject;
        float odist = 1000000000000;
        float cdist;
        if(spawn.allEnemies.Count >= 0) 
        { 
            foreach (GameObject mean in spawn.allEnemies)
            {
                cdist = Vector3.Distance(this.gameObject.transform.position, mean.transform.position);
                if (cdist<= odist)
                {
                    odist = cdist;
                    closest = mean;
                    //transform.LookAt(mean.transform);
                    //transform.eulerAngles = new Vector3(0,0, transform.eulerAngles.z);
                    //print(transform.eulerAngles.z*57.2957795);

                }
            }
            print(odist);
            return closest;
        }
        else
        {
            return gameObject;
        }
    }
}
