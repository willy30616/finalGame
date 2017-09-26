using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doortiger2 : MonoBehaviour {
    public GameObject player2;
    public openSeasme2 lastdoor;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        bool playerHasKey2 = player2.GetComponent<getkey2>().hasGoldKey2;

        if (Vector3.Distance(
                gameObject.transform.position,
                player2.transform.position) < 2f && playerHasKey2)
        {
            lastdoor.moveDown2();

        }
    }
}
