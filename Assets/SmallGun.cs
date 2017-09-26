using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallGun : MonoBehaviour {

    public Playergun pg;
    public AudioClip clip;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider other)
    {

        
                GetComponent<AudioSource>().PlayOneShot(clip);
                pg.hasGun = true;
                pg.gp = true;
                Destroy(this.gameObject);
            
    }
    
 }
