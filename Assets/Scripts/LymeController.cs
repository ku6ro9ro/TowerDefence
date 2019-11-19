using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LymeController : MonoBehaviour {
    public GameObject target;
    NavMeshAgent agent;
    private float arriveDistance = 3f;
    private float followDistance = 2f;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();	
	}
	
	// Update is called once per frame
	void Update () {
        agent.destination = target.transform.position;
        if(agent.remainingDistance < arriveDistance)
        {
            agent.isStopped = true;
            //animator
        }else if(agent.remainingDistance > followDistance)
        {
            agent.isStopped = false;
            //animator
        }
		
	}
}
