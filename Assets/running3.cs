using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class running3 : MonoBehaviour
{


    public Transform playerTransform;
    float dist3;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        NavMeshAgent nm3 = GetComponent<NavMeshAgent>();
        dist3 = Vector3.Distance(playerTransform.position, gameObject.transform.position);
        nm3.SetDestination(playerTransform.position);

        if (dist3 > 2.5)
        {
            GetComponent<Animator>().SetBool("bool3", false);
            nm3.Resume();
            nm3.SetDestination(playerTransform.position);
        }
        else
        {
            GetComponent<Animator>().SetBool("bool3", true);
            nm3.Stop();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        takeDage2 p = other.GetComponent<takeDage2>();
        if (p != null) p.TakeDamage();


    }


}