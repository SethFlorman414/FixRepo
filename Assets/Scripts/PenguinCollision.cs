using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinCollision : MonoBehaviour {

    // Use this for initialization


    public GameObject firePlace;
    

    public GameObject torch;
    public GameObject torch2;
    public GameObject torch3;
    public GameObject torch4;
    public GameObject torch5;
    

    public GameObject couch1;
    public GameObject couch2;
    public GameObject couch3;
    public GameObject couch4;
    public GameObject fire1;
    public GameObject fire2;

    public GameObject shield;

    public AudioSource sad;
   




    void Start () {

       
        sad = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.tag == "penguin")
        {

            firePlace.SetActive(true);
            

            torch.SetActive(false);
            torch2.SetActive(false);
            torch3.SetActive(false);
            torch4.SetActive(false);
            torch5.SetActive(false);
            shield.SetActive(false);

            fire1.SetActive(true);
            fire2.SetActive(true);
            couch1.SetActive(true);
            couch2.SetActive(true);
            couch3.SetActive(true);
            couch4.SetActive(true);


            sad.Play();
            firePlace.SetActive(false);




        }



    }
}
