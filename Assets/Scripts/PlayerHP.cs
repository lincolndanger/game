using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public Slider HPBar;
    public static float HP = 300;
    public static float MaxHp = 300;
    public static PlayerHP instance;
    public playerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
       instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void damaged(float Damage)
    {
        PlayerHP.HP = PlayerHP.HP - Damage;
        HPBar.value = HP;
        if(HP <= .1f)
            death();
            
    }

    public void death()
    {
        print("dead");
        pm.respawn();
    }
}
