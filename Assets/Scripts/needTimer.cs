using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class needTimer : MonoBehaviour {

    // Use this for initialization

    public float newTimer;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        newTimer += Time.deltaTime;

        if(newTimer >= 5.0f)
        {

            SceneManager.LoadScene("Start Menu");

        }

		
	}
}
