using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingBonusLevel : MonoBehaviour {

    // Use this for initialization

    public AudioSource gunShot;

    

    

	void Start () {

        gunShot = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
       

	}


    public void OnTriggerEnter(Collider other)
    {
        

        if(other.gameObject.tag == "Player")
        {

            gunShot.Play();
            
            SceneManager.LoadScene("Start Menu");


        }

    }
}
