using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponchooser : MonoBehaviour

{
    public static GameObject currentg;
    public static gun currentShooter;
    public GameObject pistol;
    public GameObject hc;
    public static int icy = 0;
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
    public GameObject monc;
    public GameObject fe;
    public GameObject smonc;
    public GameObject rang;
    public GameObject biorang;
    public GameObject lasgun;
    public GameObject laser;
    public GameObject sunbeam;
    public GameObject star;
    public GameObject sword;
    public float udamage;
    public GameObject og;
    public sliding un;
    public sliding two;
    // Start is called before the first frame update
    void Awake()
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
            Enemy.rdamage = 40;
        }

        if (Input.GetKey("1") && Input.GetKey("space"))
        {
            //machpist
            hideGuns();
            machpist.SetActive(true);
            currentg = machpist;
            Enemy.rdamage = 20;
        }

        if (Input.GetKey("1") && Input.GetKey("space") && Input.GetKey("b"))
        {
            //las
            hideGuns();
            lasgun.SetActive(true);
            currentg = lasgun;
            Enemy.rdamage = 2;
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

            if (Input.GetKey("c") && Input.GetKey("space") && Input.GetKey("m"))
        {
            //sunlaser
            hideGuns();
            sunbeam.SetActive(true);
            currentg = sunbeam;
            Enemy.rdamage = 3;
        }

        if (Input.GetKey("2") && Input.GetKey("space") && Input.GetKey("b"))
        {
            //star
            hideGuns();
            star.SetActive(true);
            currentg = star;
            Enemy.rdamage = 1;
            Time.timeScale = .2f;
        }

        if (Input.GetKey("3"))
        {
            //sniper
            hideGuns();
            sniper.SetActive(true);
            Time.timeScale = .2f;        
            currentg = sniper;
            Enemy.rdamage = 90;
        }

        if (Input.GetKey("3") && Input.GetKey("space"))
        {
            //sup
            hideGuns();
            monc.SetActive(true);
            currentg = monc;
            Enemy.rdamage = 10;
        }

            if (Input.GetKey("x") && Input.GetKey("c") && Input.GetKey("v"))
        {
            //sup
            hideGuns();
            smonc.SetActive(true);
            currentg = smonc;
            Enemy.rdamage = 3;
            
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

            if (Input.GetKey("4") && Input.GetKey("space") && Input.GetKey("b"))
        {
            //laser
            hideGuns();
            laser.SetActive(true);
            currentg = laser;
            Enemy.rdamage = .3f;
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
            icy = 1;
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

        if (Input.GetKey("j") && Input.GetKey("k") && Input.GetKey("l"))
        {
            //sfists
            hideGuns();
            sfists.SetActive(true);
            Time.timeScale = .1f;        
            currentg = sfists;
            Enemy.rdamage = 60;
        }

        if (Input.GetKey("g") && Input.GetKey("h"))
        {
            //sfists
            hideGuns();
            fe.SetActive(true);        
            currentg = fe;
            Enemy.rdamage = 3;
        }

        if (Input.GetKey("0") && Input.GetKey("space"))
        {
            //star
            hideGuns();
            sword.SetActive(true);
            currentg = sword;
            Enemy.rdamage = 30;
        }

            if (Input.GetKey("n"))
        {
            //rangers?
            hideGuns();
            rang.SetActive(true);
            currentg = rang;
            Enemy.rdamage = 1;
        }


            if (Input.GetKey("n") && Input.GetKey("space"))
        {
            //biorangers?
            hideGuns();
            biorang.SetActive(true);
            currentg = biorang;
            Enemy.rdamage = 4;
        }


            if (Input.GetKey("n") && Input.GetKey("space") && Input.GetKey("b"))
        {
            //rangers?
            hideGuns();
            rang.SetActive(true);
            currentg = rang;
            Enemy.rdamage = 5;
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
        Time.timeScale = 1;
        icy = 0;
        pistol.SetActive(false);
        sunbeam.SetActive(false);
        hc.SetActive(false);
        sniper.SetActive(false);
        smg.SetActive(false);
        flamethrower.SetActive(false);
        machgun.SetActive(false);
        shotty.SetActive(false);
        turret.SetActive(false);
        revol.SetActive(false);
        fists.SetActive(false);
        fe.SetActive(false);
        sfists.SetActive(false);
        machpist.SetActive(false);
        smgb.SetActive(false);
        spliter.SetActive(false);
        monc.SetActive(false);
        smonc.SetActive(false);
        lasgun.SetActive(false);
        rang.SetActive(false);
        biorang.SetActive(false);
        laser.SetActive(false);
        star.SetActive(false);
        sword.SetActive(false);
    }
}
