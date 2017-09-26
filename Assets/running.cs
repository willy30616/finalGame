using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class running : MonoBehaviour {


    public Transform playerTransform;
    public float dist;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        NavMeshAgent nm = GetComponent<NavMeshAgent>();
        dist = Vector3.Distance(playerTransform.position, gameObject.transform.position);
        nm.SetDestination(playerTransform.position);

        if (dist > 2)
        {
            GetComponent<Animator>().SetBool("Bool1", false);
            nm.Resume();
            nm.SetDestination(playerTransform.position);
        } else
        {
            GetComponent<Animator>().SetBool("Bool1", true);
            nm.Stop();
        }

        


        }

    void OnTriggerEnter(Collider other)
    {
        takeDamge p = other.GetComponent<takeDamge>();
        if (p != null) p.TakeDamage();


    }
}
