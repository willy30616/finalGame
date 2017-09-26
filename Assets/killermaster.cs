using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killermaster : MonoBehaviour {
    public int masterlife = 30;
    //GameObject monster;
   
   

    void Start () {	}

    void OnTriggerEnter(Collider other)
    {
        TakeDamge1();
    }

    public void TakeDamge1()
    {
       
        masterlife = masterlife - 10;

    }
    

    void Update()
    {
        if (masterlife == 0) {

            Destroy(this.gameObject);
        }
    }
}
