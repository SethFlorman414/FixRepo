using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLight : MonoBehaviour {

    // Use this for initialization

    public GameObject light;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerExit(Collider collision)
    {
        

        if(collision.gameObject.tag == "Flashlight")
        {

            light.SetActive(true);

        }

    }

}
