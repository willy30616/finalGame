using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {

    public GameObject explosionPrefab;
    public AudioClip clip111;
    void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().PlayOneShot(clip111);

        Destroy(gameObject);

        GameObject explosion = (GameObject)Instantiate(explosionPrefab,
            transform.position,
            transform.rotation
            );

        Destroy(explosion, 3.0f);
    }
}
