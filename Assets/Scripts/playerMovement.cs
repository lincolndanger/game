using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed = gun.speedy;



        if (Input.GetKey("w"))
        {
            transform.Translate(0,Time.deltaTime*speed,0);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(0,Time.deltaTime*-speed,0);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(Time.deltaTime*-speed,0,0);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(Time.deltaTime*speed,0,0);
        }


        
    }
}
