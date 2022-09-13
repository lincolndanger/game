using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float tlimer = .1f;
    public gun gvar;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

        tlimer = tlimer + Time.deltaTime;
        transform.Translate(Time.deltaTime*gvar.sbeed,0,0);
        if(tlimer > gvar.lens)
            Destroy(gameObject);

    }
    void OnTriggerEnter(Collider collider)
    { 
        Destroy(gameObject);
    }
}
