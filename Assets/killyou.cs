using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killyou : MonoBehaviour {

    public int masterlife = 10;

    

    void Start() { }


    void OnTriggerEnter(Collider other)
    {
        TakeDamge3();
    }


    public void TakeDamge3()
    {
        masterlife = masterlife - 10;
    }

    void Update()
    {
        if (masterlife == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
