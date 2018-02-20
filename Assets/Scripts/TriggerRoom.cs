using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRoom : MonoBehaviour {

    // Use this for initialization

    public GameObject boxes;



	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ControllerColliderHit(ControllerColliderHit hit)
    {
        
        if(hit.gameObject.tag == "Player")
        {

            boxes.SetActive(false);

        }

    }

}
