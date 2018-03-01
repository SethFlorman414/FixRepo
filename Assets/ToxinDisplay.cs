using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToxinDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        int toxinAmount = PlayerPrefs.GetInt("Toxins");
        GetComponent<Text>().text = ("Toxins: " + toxinAmount);

		
	}
}
