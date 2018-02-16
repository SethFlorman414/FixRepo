using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinCollision : MonoBehaviour {

    // Use this for initialization


    public GameObject firePlace;
    public GameObject statue1;
    public GameObject statue2;

    public GameObject torch;
    public GameObject torch2;
    public GameObject torch3;
    public GameObject torch4;
    public GameObject torch5;

    public GameObject shield;




    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.tag == "penguin")
        {

            firePlace.SetActive(true);
            statue1.SetActive(false);
            statue2.SetActive(false);

            torch.SetActive(false);
            torch2.SetActive(false);
            torch3.SetActive(false);
            torch4.SetActive(false);
            torch5.SetActive(false);
            shield.SetActive(false);





        }

    }
}
