﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercloserby : MonoBehaviour {

    public GetKey playerGetKey;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) < 2f)
        {
            playerGetKey.KeyGot();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }

}
