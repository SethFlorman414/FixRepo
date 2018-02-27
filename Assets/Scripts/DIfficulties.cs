using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIfficulties : MonoBehaviour {

    // Use this for initialization

    public GameObject light;
    public GameObject gameLight1;
    public GameObject gameLight2;
    public GameObject gameLight3;
   

    public GameObject health1;
    public GameObject health2;
    public GameObject toolBench;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public void OnButtonEasy()
    {


        PlayerPrefs.SetInt("Toxins", PlayerPrefs.GetInt("Toxins") + 0);


    }



    public void OnButtonMedium()
    {

        PlayerPrefs.SetInt("Toxins", PlayerPrefs.GetInt("Toxins") + 250);
        light.SetActive(false);

    }


    public void OnButtonHard()
    {

        PlayerPrefs.SetInt("Toxins", PlayerPrefs.GetInt("Toxins") + 500);
        light.SetActive(false);
        health1.SetActive(false);
        health2.SetActive(false);
        gameLight1.SetActive(false);
        gameLight2.SetActive(false);
        gameLight3.SetActive(false);

        toolBench.SetActive(true);


    }

}
