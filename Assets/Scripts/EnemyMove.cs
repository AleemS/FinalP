using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour {

    public float deathDistance = 0.5f;
    public float distanceAwayBy;
    public Transform thisObject;
    public Transform target;
    private NavMeshAgent navCompontent;

	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navCompontent = this.gameObject.GetComponent<NavMeshAgent>();
		
	}
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(target.position, transform.position);

        if(target)
        {
            navCompontent.SetDestination(target.position);
        }
        else
        {
            if(target = null)
            {
                target = this.gameObject.GetComponent<Transform>();    
            }
            else
            {
                target = GameObject.FindGameObjectWithTag("Player").transform;
            }

        }
		if (dist == deathDistance)
        {
           //GameObject.FindGameObjectWithTag("Player").SetActive(false);
           
        }
	}
}
