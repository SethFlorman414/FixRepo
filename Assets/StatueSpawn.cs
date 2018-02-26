using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueSpawn : MonoBehaviour
{

    // Use this for initialization

    public GameObject statue1;
    public GameObject statue2;
    public GameObject statue3;

    public GameObject statue4;
    public GameObject statue5;
    public GameObject statue6;
    public GameObject statue7;




    public float timer;

    public GameObject smoke;
    public AudioSource laugh;


    void Start()
    {

        laugh = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 25.0f)
        {

            statue1.SetActive(false);
            statue2.SetActive(false);
            statue3.SetActive(false);
            statue4.SetActive(false);
            statue5.SetActive(false);
            statue6.SetActive(false);
            statue7.SetActive(false);

            smoke.SetActive(true);
            

        }
        

    }


    public void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            statue1.SetActive(true);
            statue2.SetActive(true);
            statue3.SetActive(true);
            statue4.SetActive(true);
            statue5.SetActive(true);
            statue6.SetActive(true);
            statue7.SetActive(true);
            laugh.Play();

        }
    }
}
