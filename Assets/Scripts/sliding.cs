using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class sliding : MonoBehaviour
{
    public weaponchooser wc;
    public Slider heatbar;
    // Start is called before the first frame update
    void Start()
    {
        wc.currentg.GetComponent<gun>();
        
        //wc.currentg.GetComponent<gun>().heatc;
    }

    // Update is called once per frame
    void Update()
    {
        heatbar.value = 200;
    }
}
