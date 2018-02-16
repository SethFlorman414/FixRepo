using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicRoom2 : MonoBehaviour {

    // Use this for initialization

    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;
    public GameObject wall5;
    public GameObject wall6;
    public GameObject wall7;
    public GameObject wall8;
    public GameObject door;

    public GameObject knight;
    public GameObject knight2;
    public GameObject statue1;
    public GameObject statue2;
    public GameObject torch1;
    public GameObject torch2;
    public GameObject torch3;
    public GameObject torch4;
    public GameObject torch5;

    public GameObject chest1;
    public GameObject chest2;
    public GameObject chest3;
    public GameObject chest4;
    public GameObject chest5;
    public GameObject penguin;


    public Texture forWall1;
    public Texture forWall2;
    public Texture forWall3;
    public Texture forWall4;
    public Texture forWall5;
    public Texture forWall6;
    public Texture forWall7;
    public Texture forWall8;

    




    void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerExit(Collider collide)
    {
        
        if(collide.gameObject.tag == "Cross")
        {

            door.SetActive(true);
            torch1.SetActive(true);
            torch2.SetActive(true);
            torch3.SetActive(true);
            torch4.SetActive(true);
            torch5.SetActive(true);

            knight.SetActive(false);
            knight2.SetActive(false);
            statue1.SetActive(true);
            statue2.SetActive(true);

            wall1.GetComponent<Renderer>().material.mainTexture = forWall1;
            wall2.GetComponent<Renderer>().material.mainTexture = forWall2;
            wall3.GetComponent<Renderer>().material.mainTexture = forWall3;
            wall4.GetComponent<Renderer>().material.mainTexture = forWall4;
            wall5.GetComponent<Renderer>().material.mainTexture = forWall5;
            wall6.GetComponent<Renderer>().material.mainTexture = forWall6;
            wall7.GetComponent<Renderer>().material.mainTexture = forWall7;
            wall8.GetComponent<Renderer>().material.mainTexture = forWall8;

            chest1.SetActive(true);
            chest2.SetActive(true);
            chest3.SetActive(true);
            chest4.SetActive(true);
            chest5.SetActive(true);
            penguin.SetActive(true);


            

        }

    }


    

}
