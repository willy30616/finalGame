using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bulletPrefab;
    
    public AudioClip shootSound;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            
            GameObject b = Instantiate(
                bulletPrefab,
                transform.position,
                transform.rotation);
            b.GetComponent<Rigidbody>().velocity = transform.forward * 100;

            GetComponent<AudioSource>().PlayOneShot(shootSound);

        }
	}

   
}
