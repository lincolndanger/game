using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class sliding : MonoBehaviour
{
    public Slider heatbar;
    public float abc = 3;
    public gun[] shooters;
    public gun pgun;
    public int psbar;
    void Start()
    {
        //weaponchooser.currentg;
        //print(weaponchooser.currentg.GetComponentsInChildren<gun>());
        // in own function later ^
        
        CurrentShooters();

        //wc.currentg.GetComponent<gun>().heatc;
        //print(shooters[0]);
    
    }
    // Update is called once per frame
    void Update()
    {
        //heatbar.value = weaponchooser.currentg.heatc;
        heatbar.value = pgun.heatc;
    }

    public gun CurrentShooters()
    {
        shooters = weaponchooser.currentg.GetComponentsInChildren<gun>();

        for (int i = 0; i < shooters.Length; i = i+1)
        {
            if(shooters[i].ps == psbar)
            {
                pgun = shooters[i];
            }
        }

        heatbar.maxValue = pgun.heat;
        heatbar.value = heatbar.maxValue;
        return pgun;
    }    
    
}
