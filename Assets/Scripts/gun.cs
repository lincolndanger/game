using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    [Header("gun options")]
    private GameObject johnathan;
    public float sbeed = 25;
    public static float speedy = 8;
    public GameObject pbullet;
    public float timer = 0;
    private Camera cam;
    private float gunpoint;
    public float lens = .33f;
    public float cooldown = .6f;
    [Header("ammo")]
    public float heat = 100;
    public float heatc = 0;
    public bool oheated = false;
    public float reloadt;
    public int ps = 1;

    void Start()
    {
        cam = Camera.main;
        johnathan = GameObject.Find("Player");
        //StartCoroutine(heatimer());
    }


    IEnumerator heatimer()
    {
        while (true)
        {   
            print("0");
            if(oheated == true)
                print("1");
                yield return new WaitForSeconds(reloadt);
                oheated = false;
                heatc = 0;
                print("2");
            yield return new WaitForSeconds (1f);
            print("e");
            
        }
    }
    // Update is called once per frame
    void Update()
    {   
        timer = timer + Time.deltaTime;//2;
        //if(ultimatime<timer)
        //    timer = timer + Time.deltaTime/2;

        float offsetx;
        float offsety;

        if (Input.GetKey("r"))
            oheated = true;

        offsetx = johnathan.transform.position.x - cam.ScreenToWorldPoint(Input.mousePosition).x;
        offsety = johnathan.transform.position.y - cam.ScreenToWorldPoint(Input.mousePosition).y;

        gunpoint = Mathf.Atan2(offsety, offsetx) * (180/Mathf.PI);
        transform.parent.rotation = Quaternion.Euler(0, 0, -180+gunpoint);

        GameObject bull;
        
        if(ps == 1)
            if(Input.GetKey(KeyCode.Mouse0) && timer > cooldown && oheated == false)
            {
                bull = Instantiate(pbullet, gameObject.transform.position, gameObject.transform.rotation);
                bull.GetComponent<Bullet>().gvar = this;
                timer = 0;
                heatc = heatc+1;
                    if(heat < heatc)
                        oheated = true;
            }

        if(ps == 2)
            if(Input.GetKey(KeyCode.Mouse1) && timer > cooldown && oheated == false)
            {
                bull = Instantiate(pbullet, gameObject.transform.position, gameObject.transform.rotation);
                bull.GetComponent<Bullet>().gvar = this;
                timer = 0;
                heatc = heatc+1;
                    if(heat < heatc)
                        oheated = true;
            }
        

    }
}
