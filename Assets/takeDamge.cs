using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class takeDamge : MonoBehaviour {

    float Y;
    public int playerLife = 100;
    public AudioClip painClip;
    public Text txt;
    public Image image;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        txt.text = "" + playerLife;
        Color c = image.color;
        c.a = c.a - 0.04f;
        image.color = c;


        Y = transform.position.y;

        if (Y < -10)
        {

            playerLife = playerLife - 10;
        }
        

        if (playerLife <= 0)
        {
            SceneManager.LoadScene("scene1", LoadSceneMode.Single);
        }

    }

    public void TakeDamage()
    {
        
        GetComponent<AudioSource>().PlayOneShot(painClip);
        playerLife = playerLife - 10;
        Color c = image.color;
        c.a = 1;
        image.color = c;
        if (playerLife <= 0)
        {
            SceneManager.LoadScene("scene1", LoadSceneMode.Single);
        }

    }
}
