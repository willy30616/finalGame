using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSeasme2 : MonoBehaviour {

    public GameObject player2;


    public bool opening = false;
   
   

    public void moveDown2()
    {
        opening = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (opening)
        {
            transform.Translate(0, -Time.deltaTime / 2, 0);
        }
    }
}
