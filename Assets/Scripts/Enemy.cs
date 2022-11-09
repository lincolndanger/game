using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform good;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
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
            Destroy(gameObject);
        }
    }
}
