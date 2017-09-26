using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoSeasme : MonoBehaviour {

    public GameObject player;
   

    void Start()
    {

    }

 
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) <  3f)
        {
            transform.Translate(0, -Time.deltaTime / 2, 0);
        }
    }
}
