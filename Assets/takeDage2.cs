using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class takeDage2 : MonoBehaviour {
    float Y;
    public int playerLife = 20;
    public AudioClip painClip;
    public AudioClip painClip2;
    public Text txt1;
    public Image image1;


    void Update()
    {

        txt1.text = "" + playerLife;
        Color c = image1.color;
        c.a = c.a - 0.05f;
        image1.color = c;

        Y = transform.position.y;

        if (Y < -10)
        {
            GetComponent<AudioSource>().PlayOneShot(painClip2);
            playerLife = playerLife - 10;
        }


        if (playerLife <= 0)
        {
            SceneManager.LoadScene("theEndScene", LoadSceneMode.Single);
        }

    }

    public void TakeDamage()
    {

        GetComponent<AudioSource>().PlayOneShot(painClip);
        playerLife = playerLife - 10;
        Color c = image1.color;
        c.a = 1;
        image1.color = c;
        if (playerLife <= 0)
        {
            GetComponent<AudioSource>().PlayOneShot(painClip2);
            SceneManager.LoadScene("theEndScene", LoadSceneMode.Single);
        }

    }


}
