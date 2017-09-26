using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playergun : MonoBehaviour {

    
    public bool hasGun = false;
    public bool gp = false;
    public GameObject imageObject;
    public GameObject playergun;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       

        if (hasGun) {
            imageObject.SetActive(true);
            playergun.SetActive(true);

            
        }

       
        
    }
}
