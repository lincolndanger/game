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
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        maxmeanhp = meanhp;
		agent.updateRotation = false;
		agent.updateUpAxis = false;
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
        Time.timeScale = .15f;
        yield return new WaitForSecondsRealtime(.2f);
        Time.timeScale = 1;
        if(meanhp <= 1f)
        {
            Destroy(gameObject);
        }
        print("functional");
        yield return new WaitForSeconds(.695f);
    }
}
