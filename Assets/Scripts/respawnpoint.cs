using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class respawnpoint : MonoBehaviour
{
    public int nsv;
    public int nxpv;
    // Start is called before the first frame update
    void Start()
    {
        nxpv = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {   
        if(collider.tag == "Player")
        {
            if(Enemy.xp >= nxpv)
                SceneManager.LoadScene(nsv);

        }
    }
}
