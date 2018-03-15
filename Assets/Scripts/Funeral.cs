using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funeral : MonoBehaviour {

    // Use this for initialization

    public GameObject arch1;
    public GameObject arch2;
    public GameObject statue1;
    public GameObject statue2;
    public GameObject coffin;
    public GameObject sideStatue;
    public GameObject sideStatue2;
    

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerEnter(Collider other)
    {
        

        if(other.gameObject.tag == "Player")
        {

            coffin.SetActive(true);
            sideStatue.SetActive(true);
            sideStatue2.SetActive(true);

            arch1.SetActive(false);
            arch2.SetActive(false);
            statue1.SetActive(false);
            statue2.SetActive(false);


        }

    }


}
