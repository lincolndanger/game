using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider : MonoBehaviour
{
    public weaponchooser wc;
    public float b;
    // Start is called before the first frame update
    void Start()
    {
        wc.currentg.GetComponent<gun>();
    }

    // Update is called once per frame
    void Update()
    {
        b = wc.currentg.GetComponent<gun>().heatc;
    }
}
