using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinCollision : MonoBehaviour {

    // Use this for initialization


    public GameObject firePlace;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "penguin")
        {




        }

    }
}
