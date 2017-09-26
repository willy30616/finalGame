using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercloserby2 : MonoBehaviour {

    public getkey2 playerGetKey2;
    public GameObject player2;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player2.transform.position, gameObject.transform.position) < 2f)
        {
            playerGetKey2.KeyGot2();
        }

      
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
