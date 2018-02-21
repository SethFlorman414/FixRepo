using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRoom : MonoBehaviour {

    // Use this for initialization

    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;




    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider collide)
    {

        if (collide.gameObject.tag == "Player")
        {

            box1.SetActive(false);
            box2.SetActive(false);
            box3.SetActive(false);
            box4.SetActive(false);
            box5.SetActive(false);

        }

    }

}
