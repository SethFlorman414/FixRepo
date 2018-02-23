using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFireplace : MonoBehaviour {

    // Use this for initialization

    public int fireHealth;
    public GameObject firePlace;

	void Start () {
        PlayerPrefs.SetInt("Health", fireHealth);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "axe")
        {

            PlayerPrefs.SetInt("Health", PlayerPrefs.GetInt("Health") - 1);

            if(fireHealth <= 0)
            {

                Destroy(firePlace);

            }
            



        }


    }

}
