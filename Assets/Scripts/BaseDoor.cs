using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDoor : MonoBehaviour {

    // Use this for initialization

    public Animator anim;

	void Start () {

        
        

	}
	
	// Update is called once per frame
	void Update () {
		



	}


    public void OnTriggerEnter(Collider other)
    {

        
        if(other.gameObject.tag == "Player")
        {
           // Debug.Log("player");
            anim.SetBool("playerTrigger", true);
            

        }


    }

}
