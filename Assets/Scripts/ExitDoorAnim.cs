using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoorAnim : MonoBehaviour {

    // Use this for initialization

    public Animator leavingAnim;
    public GameObject newCamera;
    public GameObject lightSource;
    public GameObject playerController;

    

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
		
	}


    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {

            playerController.SetActive(false);
            lightSource.SetActive(true);
            newCamera.SetActive(true);
            leavingAnim.SetBool("LastDoor", true);


            gameObject.GetComponent<needTimer>().enabled = true;




        }


    }

}
