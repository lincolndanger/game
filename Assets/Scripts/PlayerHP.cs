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
    public float iframes = 0;
    public playerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
       instance = this;
       HP = MaxHp;
    }

    // Update is called once per frame
    void Update()
    {
        print(HP);
        if(iframes >= 0)
        {
            iframes = iframes - 1;
        }
    }

    public void damaged(float Damage)
    {
        if(iframes <= 0)
        {
            HP = HP - Damage;
            HPBar.value = HP;
            iframes = 100;
            print("damaged");
        }
        if(HP <= .1f)
        {
            print("hp is 0"+HP);
            print(Damage);
            death();
        }
            
    }

    public void death()
    {
        print("dead");
        pm.respawn();
    }
}
