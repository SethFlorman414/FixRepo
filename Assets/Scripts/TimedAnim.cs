using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedAnim : MonoBehaviour {

    // Use this for initialization

    public float timer2;
    public Animator openAnim;

	void Start () {

        
		
	}
	
	// Update is called once per frame
	void Update () {


        timer2 += Time.deltaTime;

        if(timer2 >= 50.0f)
        {

            openAnim.SetBool("doorTrigger", true);

        }
		
	}
}
