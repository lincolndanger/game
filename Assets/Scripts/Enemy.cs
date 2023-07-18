using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform good;
    public float meanhp;
    public float maxmeanhp;
    public int Damage;
    public static float xp;
    static public float rdamage;
    //public Transform goodzwei;
    public bool wall = false;
    //public Transform nw;
    NavMeshAgent agent;
    public int destroyer = 0;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        maxmeanhp = meanhp;
		agent.updateRotation = false;
		agent.updateUpAxis = false;
        // if(destroyer == 1)
        // {
        //     agent.Warp(new Vector3(-115,-187, 0));
        // }
        if(wall == true)
        {
            meanhp = transform.localScale.x * transform.localScale.y * 20;
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = good.position;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {   
        if(collider.tag == "BULLET")
        {
            StartCoroutine(hit());

        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.transform.tag == "Player")
        {
            StartCoroutine(Damig());
        }
    }

    IEnumerator Damig()
    {
        PlayerHP.instance.damaged(Damage);
        yield return new WaitForSeconds(1.5f);
    }

    IEnumerator hit()
    {
        meanhp = meanhp - rdamage;
        xp = xp + maxmeanhp;
        Time.timeScale = .18f;
        yield return new WaitForSecondsRealtime(.05f);
        Time.timeScale = 1f;
        if(meanhp <= 1f)
        {
            spawn.allEnemies.Remove(gameObject);
            Destroy(gameObject);
        }
        // if(weaponchooser.icy >= 0)
        // {
        //     goodzwei = good;
        //     good = nw;
        //     yield return new WaitForSeconds(weaponchooser.icy);
        //     good = goodzwei;
        // }
        yield return new WaitForSeconds(.695f);
    }
}
