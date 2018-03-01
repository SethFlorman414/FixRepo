using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTimer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {

            gameObject.GetComponent<needTimer>().enabled = true;

        }


    }

}
