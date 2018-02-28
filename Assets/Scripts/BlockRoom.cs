using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRoom : MonoBehaviour {

    // Use this for initialization

    public GameObject door;
    public GameObject blockWall;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {

            door.SetActive(false);
            blockWall.SetActive(true);


        }


    }

}
