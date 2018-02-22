using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToxins : MonoBehaviour {

    // Use this for initialization

    public int toxinEffect;
    

	void Start () {

        PlayerPrefs.SetInt("Toxins", toxinEffect);

    }
	
	// Update is called once per frame
	void Update () {
        toxinEffect = PlayerPrefs.GetInt("Toxins");
    }

    public void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Player")
        {

            PlayerPrefs.SetInt("Toxins", PlayerPrefs.GetInt("Toxins") + 15);
            
        }

    }

}
