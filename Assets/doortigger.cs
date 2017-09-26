using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doortigger : MonoBehaviour {


    public GameObject player;
    public OpenSesame pikadoor;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        bool playerHasKey = player.GetComponent<GetKey>().hasGoldKey;

        if (Vector3.Distance(
                gameObject.transform.position,
                player.transform.position) < 2f && playerHasKey)
        {
            pikadoor.moveDown();

        }
    }
}
