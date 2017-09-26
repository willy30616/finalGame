using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour {

    public GameObject missilePrefab;

    public AudioClip missileSound;

    // Use this for initialization
    void Start () {
		
	}
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            GameObject b = Instantiate(
                missilePrefab,
                transform.position,
                transform.rotation);
            b.GetComponent<Rigidbody>().velocity = transform.forward * 50;

            GetComponent<AudioSource>().PlayOneShot(missileSound);

        }
    }
}
