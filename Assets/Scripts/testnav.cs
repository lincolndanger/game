using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class testnav : MonoBehaviour
{
    public Transform goal;
    
    // Start is called before the first frame update
    void Start()
    {
		var agent = GetComponent<NavMeshAgent>();
		agent.updateRotation = false;
		agent.updateUpAxis = false;
        agent.destination = goal.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
