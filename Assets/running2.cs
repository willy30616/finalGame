using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class running2 : MonoBehaviour {


    public Transform playerTransform;
    public float dist2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        NavMeshAgent nm2 = GetComponent<NavMeshAgent>();
        dist2 = Vector3.Distance(playerTransform.position, gameObject.transform.position);
        nm2.SetDestination(playerTransform.position);

        if (dist2 > 4.5)
        {
            GetComponent<Animator>().SetBool("bool2", false);
            nm2.Resume();
            nm2.SetDestination(playerTransform.position);
        }
        else
        {
            GetComponent<Animator>().SetBool("bool2", true);
            nm2.Stop();
        }

    }

    void OnTriggerEnter(Collider other)
    {
        takeDage2 p = other.GetComponent<takeDage2>();
        if (p != null) p.TakeDamage();


    }
}
