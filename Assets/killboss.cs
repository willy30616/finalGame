using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killboss : MonoBehaviour {

    public int M = 1000;
    public AudioClip painClip2;

    void OnTriggerEnter(Collider other)
    {
        TakeDame2();
    }

    public void TakeDame2()
    {
        M = M -5;

    }

    void Update() {
        GetComponent<AudioSource>().PlayOneShot(painClip2);

        if (M == 0) {
            Destroy(this.gameObject);
        }
    }
}
