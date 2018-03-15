using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlamingFuneral : MonoBehaviour {

    // Use this for initialization

    public GameObject statue;
    public GameObject statue2;
    public GameObject coffin;

    public GameObject arch1;
    public GameObject arch2;
    public GameObject statue11;
    public GameObject statue22;

    public GameObject fire;
    

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerEnter(Collider other)
    {
        

        if(other.gameObject.tag == "Player")
        {


            arch1.SetActive(false);
            arch2.SetActive(false);
            statue11.SetActive(false);
            statue22.SetActive(false);

            statue.SetActive(true);
            statue2.SetActive(true);
            coffin.SetActive(true);

            fire.SetActive(true);

        }

    }

}
