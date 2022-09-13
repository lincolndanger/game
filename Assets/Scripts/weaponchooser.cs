using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponchooser : MonoBehaviour

{
    public static GameObject currentg;
    public GameObject pistol;
    public GameObject hc;
    public GameObject sniper;
    public GameObject smg;
    public GameObject flamethrower;
    public GameObject machgun;
    public GameObject shotty;
    public GameObject turret;
    public GameObject revol;
    public GameObject fists;
    public GameObject sfists;
    public GameObject machpist;
    public GameObject smgb;
    public GameObject spliter;
    // Start is called before the first frame update
    void Start()
    {
        currentg = fists;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            //pistol
            hideGuns();
            pistol.SetActive(true);
            currentg = pistol;
        }

        if (Input.GetKey("1") && Input.GetKey("space"))
        {
            //machpist
            hideGuns();
            machpist.SetActive(true);
            currentg = machpist;
        }

        if (Input.GetKey("2"))
        {
            //heavy cal
            hideGuns();
            hc.SetActive(true);
            currentg = hc;
        }

        if (Input.GetKey("2") && Input.GetKey("space"))
        {
            //spliter
            hideGuns();
            spliter.SetActive(true);
            currentg = spliter;
        }

        if (Input.GetKey("3"))
        {
            //sniper
            hideGuns();
            sniper.SetActive(true);
            currentg = sniper;
        }
        
        if (Input.GetKey("4"))
        {
            //SMG
            hideGuns();
            smg.SetActive(true);
            currentg = smg;
        }

            if (Input.GetKey("4") && Input.GetKey("space"))
        {
            //SMG B
            hideGuns();
            smgb.SetActive(true);
            currentg = smgb;
        }

        if (Input.GetKey("5"))
        {   
            hideGuns();
            flamethrower.SetActive(true);
            currentg = flamethrower;
        }

        if (Input.GetKey("6"))
        {
            //Machine Gun
            hideGuns();
            machgun.SetActive(true);
            currentg = machgun;
        }

        if (Input.GetKey("7"))
        {
            //shotgun
            hideGuns();
            shotty.SetActive(true);
            currentg = shotty;
        }

        if (Input.GetKey("8"))
        {
            //turret
            hideGuns();
            turret.SetActive(true);
            currentg = turret;
        }

        if (Input.GetKey("9"))
        {
            //turret
            hideGuns();
            revol.SetActive(true);
            currentg = revol;
        }
        
        if (Input.GetKey("0"))
        {
            //fists
            hideGuns();
            fists.SetActive(true);
            currentg = fists;
        }

        if (Input.GetKey("0") && Input.GetKey("space"))
        {
            //sfists
            hideGuns();
            sfists.SetActive(true);
            currentg = sfists;
        }
    }

    void hideGuns()
    {
        pistol.SetActive(false);
        hc.SetActive(false);
        sniper.SetActive(false);
        smg.SetActive(false);
        flamethrower.SetActive(false);
        machgun.SetActive(false);
        shotty.SetActive(false);
        turret.SetActive(false);
        revol.SetActive(false);
        fists.SetActive(false);
        sfists.SetActive(false);
        machpist.SetActive(false);
        // smgb.SetActive(false);
        spliter.SetActive(false);
    }
}
