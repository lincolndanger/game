using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public static float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //speed = weaponchooser.currentg.GetComponent<gun>().speedy;

        //print(weaponchooser.currentg.GetComponent<gun>());



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

    public void respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
