using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponchooser : MonoBehaviour

{
    public static GameObject currentg;
    public static gun currentShooter;
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
    public GameObject og;
    public sliding un;
    public sliding two;
    // Start is called before the first frame update
    void Awake()
    {
        //fists.SetActive(true);
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
            Enemy.rdamage = 25;
        }

        if (Input.GetKey("1") && Input.GetKey("space"))
        {
            //machpist
            hideGuns();
            machpist.SetActive(true);
            currentg = machpist;
            Enemy.rdamage = 18;
        }

        if (Input.GetKey("2"))
        {
            //heavy cal
            hideGuns();
            hc.SetActive(true);
            currentg = hc;
            Enemy.rdamage = 45;
        }

        if (Input.GetKey("2") && Input.GetKey("space"))
        {
            //spliter
            hideGuns();
            spliter.SetActive(true);
            currentg = spliter;
            Enemy.rdamage = 33;
        }

        if (Input.GetKey("3"))
        {
            //sniper
            hideGuns();
            sniper.SetActive(true);
            currentg = sniper;
            Enemy.rdamage = 90;
        }
        
        if (Input.GetKey("4"))
        {
            //SMG
            hideGuns();
            smg.SetActive(true);
            currentg = smg;
            Enemy.rdamage = 15;
        }

            if (Input.GetKey("4") && Input.GetKey("space"))
        {
            //SMG B
            hideGuns();
            smgb.SetActive(true);
            currentg = smgb;
            Enemy.rdamage = 10;
        }

        if (Input.GetKey("5"))
        {   
            hideGuns();
            flamethrower.SetActive(true);
            currentg = flamethrower;
            Enemy.rdamage = 4;
        }

        if (Input.GetKey("6"))
        {
            //Machine Gun
            hideGuns();
            machgun.SetActive(true);
            currentg = machgun;
            Enemy.rdamage = 15;
        }

        if (Input.GetKey("7"))
        {
            //shotgun
            hideGuns();
            shotty.SetActive(true);
            currentg = shotty;
            Enemy.rdamage = 50;
        }

        if (Input.GetKey("8"))
        {
            //turret
            hideGuns();
            turret.SetActive(true);
            currentg = turret;
            Enemy.rdamage = 60;
        }

        if (Input.GetKey("9"))
        {
            //turret
            hideGuns();
            revol.SetActive(true);
            currentg = revol;
            Enemy.rdamage = 30;
        }
        
        if (Input.GetKey("0"))
        {
            //fists
            hideGuns();
            fists.SetActive(true);
            currentg = fists;
            Enemy.rdamage = 12;
        }

        if (Input.GetKey("0") && Input.GetKey("space"))
        {
            //sfists
            hideGuns();
            sfists.SetActive(true);
            currentg = sfists;
            Enemy.rdamage = 6;
        }
// gun swap spot
        if (currentg != og) 
        {
            og = currentg;
            //print ("s");
            currentShooter = un.CurrentShooters();
            two.CurrentShooters();
            playerMovement.speed = currentShooter.speedy;
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
        smgb.SetActive(false);
        spliter.SetActive(false);
    }
}
