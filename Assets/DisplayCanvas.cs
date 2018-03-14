using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCanvas : MonoBehaviour {

	// Use this for initialization

        public GameObject canvas;
   


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerEnter(Collider other)
    {
        

        if(other.gameObject.tag == "Player")
        {


            canvas.GetComponent<Canvas>().enabled = true;

        }
        


        

    }

    public void OnTriggerExit(Collider other)
    {


        if (other.gameObject.tag == "Player")
        {

            canvas.GetComponent<Canvas>().enabled = false;

        }

    }

}
